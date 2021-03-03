using FerroApp.Consume.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FerroApp.Consume.Controllers
{
    public class ClienteController : Controller
    {
        public async Task<ActionResult> Index(Cliente cliente)
        {
            
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("https://localhost:44367/api/cliente");
            var ListClientes = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Cliente>>>(Json);

            return View(ListClientes.Data);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente CrearCliente, int IdUsuario)
        {
            //string UserId;
            
            using (var client = new HttpClient())
               
            {
                CrearCliente.IdUsuario = int.Parse(HttpContext.Session.GetString("Id"));
                //if (TempData["UserId"])

                //    ViewBag.UserId = TempData["UserId"].ToString();
                client.BaseAddress = new Uri("https://localhost:44367/api/cliente");
                var CrearClient = client.PostAsJsonAsync<Cliente>("https://localhost:44367/api/cliente", CrearCliente);
                
                CrearClient.Wait();
                
                var CreaResult = CrearClient.Result;
                if (CreaResult.IsSuccessStatusCode)
                    //return View();
                return RedirectToAction("Index", "Home");

            }
            //return RedirectToAction("Productos","Producto");
            return View();
        }


        //consumo para modificar
        public ActionResult Update(int IdCliente, Cliente cliente)
        {
            Cliente clientes = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/");
                var responseTask = client.GetAsync("cliente/" + IdCliente.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ApiResponse<Cliente>>();
                    readTask.Wait();

                    cliente = readTask.Result.Data;
                }
            }
            return View(clientes);
        }
        [HttpPost]
        public ActionResult Update(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/cliente");
                var putTask = client.PutAsJsonAsync<Cliente>($"/api/Cliente/", cliente);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            return View(cliente);
        }

        //Delete Product
        public ActionResult Delete(int IdCliente)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44367/api/");
                var deleteTask = client.DeleteAsync("Cliente/" + IdCliente.ToString());
                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
