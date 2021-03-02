using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.Consume.Controllers
{
    public class AdministrarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
