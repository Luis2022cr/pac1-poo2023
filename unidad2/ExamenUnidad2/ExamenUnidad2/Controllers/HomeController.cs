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
		private readonly IRepositorioAlumnos _repositorioAlumnos;

		public HomeController(ILogger<HomeController> logger, IRepositorioAlumnos repositorioAlumnos)
		{
			_logger = logger;
			this._repositorioAlumnos = repositorioAlumnos;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Listado()
		{
			var alumnos = _repositorioAlumnos.ObtenerAlumnos();

			var alumnosViewModel = new AlumnoViewModel
			{
				Alumnos = alumnos.ToList(),
			};

			return View(alumnosViewModel);
		}

		public IActionResult Crear()
		{
			return View("Index");
		}

		[HttpPost]
		public IActionResult Crear(Models.Alumno alumno)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", alumno);
			}

			_repositorioAlumnos.AgregarAlumno(alumno);

			return RedirectToAction("Listado");
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