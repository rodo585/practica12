using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica12.Models;

namespace practica12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

             
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(string numero1, string numero2, string tipo)
        {
            int b = Convert.ToInt32(numero1);
            int a = Convert.ToInt32(numero2);
            int c = 0;
            if(tipo=="Triangulo")
            {
                c=b+a/2;
                
                ViewBag.Resultado = c;
            }
            else
            {
                c = b*a;
                ViewBag.Resultado = c;
            }
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
