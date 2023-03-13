using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portafolio.Interfaces;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(
            ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos)

        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            /*
             *LogTrace
             *LogDebug
             *LogInformation
             *LogWarning
             *LogError
             *LogCritical
             */


            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            
            var modelo = new HomeIndexViewModel() 
            {
                Proyectos = proyectos
            };

            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

            //_logger.LogTrace("Este es un mensaje de Trace");
            //_logger.LogDebug("Este es un mensaje de Debug");
            //_logger.LogInformation("Este es un mensaje de Information");
            //_logger.LogWarning("Este es un mensaje de Warning");
            //_logger.LogError("Este es un mensaje de Error");
            //_logger.LogCritical("Este es un mensaje de Critical");

            //var apellido = configuration.GetValue<string>("apellido");

            //_logger.LogInformation("El apellido es: " + apellido);
                 
                //EjemploGuid_1 = guidViewModel,
                //EjemploGuid_2 = guidViewModel2


            //var guidViewModel = new EjemploGuidViewModel
            //{
            //    Transitorio = servicioTransitorio.ObtenerGuid,
            //    DeLimitado =  servicioDeLimitado.ObtenerGuid,
            //    Unico = servicioUnico.ObtenerGuid
            //};

            //var guidViewModel2 = new EjemploGuidViewModel
            //{
            //    Transitorio = servicioTransitorio2.ObtenerGuid,
            //    DeLimitado = servicioDeLimitado2.ObtenerGuid,
            //    Unico = servicioUnico2.ObtenerGuid
            //};


            //this.servicioTransitorio = servicioTransitorio;
            //this.servicioDeLimitado = servicioDeLimitado;
            //this.servicioUnico = servicioUnico;
            //this.servicioTransitorio2 = servicioTransitorio2;
            //this.servicioDeLimitado2 = servicioDeLimitado2;
            //this.servicioUnico2 = servicioUnico2;





            //ServicioTransitorio servicioTransitorio,
            //ServicioDeLimitado servicioDeLimitado,
            //ServicioUnico servicioUnico,
            //ServicioTransitorio servicioTransitorio2,
            //ServicioDeLimitado servicioDeLimitado2,
            //ServicioUnico servicioUnico2)



        //private readonly ServicioTransitorio servicioTransitorio;
        //private readonly ServicioDeLimitado servicioDeLimitado;
        //private readonly ServicioUnico servicioUnico;
        //private readonly ServicioTransitorio servicioTransitorio2;
        //private readonly ServicioDeLimitado servicioDeLimitado2;
        //private readonly ServicioUnico servicioUnico2;