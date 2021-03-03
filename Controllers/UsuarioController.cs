using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FerroApp.Consume.Controllers
{
    public class UsuarioController : Controller
    {
        //public ActionResult Index()
        //{
        //    IEnumerable<Usuario> usuario = null;
        //    using (var Client = new HttpClient())
        //    {
        //        Client.BaseAddress = new Uri("https://localhost:44367/api/");
        //        var responseTask = Client.GetAsync("usuario");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readjob = result.Content.ReadAsAsync<IList<Usuario>>();
        //            readjob.Wait();
        //            usuario = readjob.Result;
        //        }


        //    }
        //    return View(usuario);
        //}
        public ActionResult Index()
        {
            IEnumerable<Usuario> usuario = null;
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44367/api/");
                var responseTask = Client.GetAsync("usuario");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readjob = result.Content.ReadAsAsync<IList<Usuario>>();
                    readjob.Wait();
                    usuario = readjob.Result;
                }


            }
            return View(usuario);
        }
        //public async Task<ActionResult> Index()
        //{
        //    var httpClient = new HttpClient();
        //    var Json = await httpClient.GetStringAsync("https://localhost:44367/api/usuario");
        //    var ListUsuar = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Usuario>>>(Json);

        //    return View(ListUsuar.Data);
        //}



        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario CrearUsuario, int IdUsuario)
        {
            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri("https://localhost:44367/api/usuario");
                var CrearUsuar = client.PostAsJsonAsync<Usuario>("https://localhost:44367/api/usuario", CrearUsuario);
                CrearUsuar.Wait();
                var CreaResult = CrearUsuar.Result;
                if (CreaResult.IsSuccessStatusCode)

                    //return View();
               return RedirectToAction/*("Index")*/("Index", "Login");

            }
            //return View(CrearUsuario);
            /*return RedirectToAction("Productos","Producto");*/
            //return RedirectToAction/*("Index")*/("Create", "Cliente");
            return View();
        }

        //consumo para modificar
        public ActionResult Update(int IdUsuario, Usuario usuario)
        {
            Usuario usuarios = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/");
                var responseTask = client.GetAsync("usuario/" + IdUsuario.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ApiResponse<Usuario>>();
                    readTask.Wait();

                    usuario = readTask.Result.Data;
                }
            }
            return View(usuarios);
        }
        [HttpPost]
        public ActionResult Update(Usuario usuario)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/usuario");
                var putTask = client.PutAsJsonAsync<Usuario>($"/api/Usuario/", usuario);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            return View(usuario);
        }
    }
}
