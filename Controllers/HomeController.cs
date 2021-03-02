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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Productos()
        {
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("https://localhost:44367/api/producto");
            var ListProductos = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Producto>>>(Json);

            return View(ListProductos.Data);
        }
    }
}

