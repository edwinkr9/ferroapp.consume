using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FerroApp.Consume.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;



        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        HttpClient Client = new HttpClient();
        public string url = "https://localhost:44367/api/usuario";
        //public string urlv = "https://localhost:44367/api/cliente";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Login login, Usuario usuario)
        {
            var json = await Client.GetStringAsync(url);

            var Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            var _Usuario = Usuarios.FirstOrDefault(e => usuario.Correo.Equals(login.Correo) && usuario.Contraseña.Equals(login.Password));
            if (_Usuario != null)
            {
                HttpContext.Session.SetString("Id", _Usuario.IdUsuario.ToString());
                return RedirectToAction("Index", "Producto");
                //return View();

            }
            else if (_Usuario == null)
            {

                login.status = false;
                return View();
               
            }
            return View();
            //return RedirectToAction("Index", "Producto");

        }

        public IActionResult Usuario()
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                return RedirectToAction("Index", "Producto");

            }
            else
            {
                return View();
            }
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Id");
            return RedirectToAction("Index", "Home");
        }
    }
}
