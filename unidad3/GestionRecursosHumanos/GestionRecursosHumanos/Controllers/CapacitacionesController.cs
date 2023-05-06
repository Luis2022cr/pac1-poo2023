using GestionRecursosHumanos.Models;
using GestionRecursosHumanos.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionRecursosHumanos.Controllers
{
	public class CapacitacionesController : Controller
	{
		private readonly IRepositorioCapacitaciones repositorioCapacitaciones;
		private readonly IRepositorioDepartamentos repositorioDepartamentos;
		private readonly IRepositorioEmpleados repositorioEmpleados;
		private readonly IServicioUsuarios servicioUsuarios;

		public CapacitacionesController
			(IRepositorioCapacitaciones repositorioCapacitaciones, IRepositorioDepartamentos repositorioDepartamentos,
			IRepositorioEmpleados repositorioEmpleados, IServicioUsuarios servicioUsuarios)
		{
			this.repositorioCapacitaciones = repositorioCapacitaciones;
			this.repositorioDepartamentos = repositorioDepartamentos;
			this.repositorioEmpleados = repositorioEmpleados;
			this.servicioUsuarios = servicioUsuarios;
		}

		public async Task<IActionResult> Index()
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			//var capacitacionesConDepartamento = await repositorioCapacitaciones.ObtenerCapacitaciones(usuarioId);
			var capacitaciones = await repositorioCapacitaciones.ObtenerCapacitaciones(usuarioId);

			var modelo = new ObtenerCapacitacionesViewModel
			{
				Capacitaciones = capacitaciones.Select(capacitacion => new CapacitacionDTO 
				{
					Id = capacitacion.Id,
					Nombre = capacitacion.Nombre,
					Fecha = capacitacion.Fecha,
					NombreDepartamento = capacitacion.Departamento,
					NombreEmpleado = capacitacion.Empleado,
					Duracion = capacitacion.Duracion,
					Costo = capacitacion.Costo,
					Descripcion = capacitacion.Descripcion,
				})
			};

			return View(modelo);
		}

		[HttpGet]
		public async Task<IActionResult> Crear()
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			var modelo = new CapacitacionCreacionViewModel();

			modelo.Empleados = await ObtenerEmpleados(usuarioId);
			modelo.Departamentos = await ObtenerDepartamentos(usuarioId);

			return View(modelo);
		}

		[HttpPost]
		public async Task<IActionResult> Crear(CapacitacionCreacionViewModel modelo)
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			modelo.UsuarioId = usuarioId;

			if (!ModelState.IsValid)
			{
				modelo.Departamentos = await ObtenerDepartamentos(usuarioId);
				modelo.Empleados = await ObtenerEmpleados(usuarioId);
				return View(modelo);
			}

			var empleado = await repositorioEmpleados.ObtenerPorId(modelo.EmpleadoId, usuarioId);
			if (empleado is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			var departamento = await repositorioDepartamentos.ObtenerPorId(modelo.DepartamentoId, usuarioId);
			if (departamento is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			await repositorioCapacitaciones.Crear(modelo);

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Editar(int id)
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			var capacitacion = await repositorioCapacitaciones.ObtenerPorId(id, usuarioId);

			if (capacitacion is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			var modelo = new CapacitacionCreacionViewModel
			{
				Id = capacitacion.Id,
				Nombre = capacitacion.Nombre,
				Fecha = capacitacion.Fecha,
				Departamento = capacitacion.Departamento,
				Empleado = capacitacion.Empleado,
				Duracion = capacitacion.Duracion,
				Costo = capacitacion.Costo,
				Descripcion = capacitacion.Descripcion,
			};

			modelo.Empleados = await ObtenerEmpleados(usuarioId);
			modelo.Departamentos = await ObtenerDepartamentos(usuarioId);

			return View(modelo);
		}

		[HttpPost]
		public async Task<IActionResult> Editar(CapacitacionCreacionViewModel modelo)
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			var capacitacion = await repositorioCapacitaciones.ObtenerPorId(modelo.Id, usuarioId);

			if (!ModelState.IsValid)
			{
				modelo.Departamentos = await ObtenerDepartamentos(usuarioId);
				modelo.Empleados = await ObtenerEmpleados(usuarioId);
				return View(modelo);
			}

			if (capacitacion is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			var departamento = await repositorioDepartamentos.ObtenerPorId(modelo.DepartamentoId, usuarioId);
			if (departamento is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			var empleado = await repositorioEmpleados.ObtenerPorId(modelo.EmpleadoId, usuarioId);
			if (empleado is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			await repositorioCapacitaciones.Actualizar(modelo);

			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> Borrar(int id)
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			var capacitacion = await repositorioCapacitaciones.ObtenerPorId(id, usuarioId);

			if (capacitacion is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			return View(capacitacion);
		}

		[HttpPost]
		public async Task<IActionResult> BorrarConfirm(int id)
		{
			var usuarioId = servicioUsuarios.ObtenerUsuarioId();
			var capacitacion = await repositorioCapacitaciones.ObtenerPorId(id, usuarioId);

			if (capacitacion is null)
			{
				return RedirectToAction("NoEncontrado", "Home");
			}

			await repositorioCapacitaciones.Borrar(id);

			return RedirectToAction("Index");
		}

		private async Task<IEnumerable<SelectListItem>> ObtenerDepartamentos(int usuarioId)
		{
			var departamentos = await repositorioDepartamentos.Obtener(usuarioId);
			return departamentos.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
		}

		private async Task<IEnumerable<SelectListItem>> ObtenerEmpleados(int usuarioId)
		{
			var empleados = await repositorioEmpleados.ObtenerEmpleados(usuarioId);
			return empleados.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
		}
	}
}
