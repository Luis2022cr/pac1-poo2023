using ExamenUnidad2.Interfaces;
using ExamenUnidad2.Models;
using ExamenUnidad2.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamenUnidad2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioAlumnos repositorioAlumnos;


        public HomeController(ILogger<HomeController> logger, IRepositorioAlumnos repositorioAlumnos)
        {
            _logger = logger;
            this.repositorioAlumnos = repositorioAlumnos;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listado()
        {
            //var alumnos = repositorioAlumnos.ObtenerAlumnos();

            //var modelo = new AlumnoViewModel
            //{
            //    Alumnos = alumnos.ToList()
            //};
            //return View(modelo);
            return View();

        }


		[HttpPost]
		public IActionResult Listado(Alumno datos)
        {
            ViewBag.Nombre = datos.Nombre;
            ViewBag.Apellido = datos.Apellido;
            ViewBag.NumeroDeCuenta = datos.NumeroDeCuenta;
            ViewBag.Presente = datos.Presente;

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