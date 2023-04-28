using ForoUnidad2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace ForoUnidad2.Controllers
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
         public static List<Datos> _datos = new List<Datos>();
        public IActionResult Agenda()
        {
            return View(_datos);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Datos contacto)
        {
            _datos.Add(contacto);
            _logger.LogCritical(contacto.Nombre);
            return RedirectToAction("Agenda");
        }


    }

}