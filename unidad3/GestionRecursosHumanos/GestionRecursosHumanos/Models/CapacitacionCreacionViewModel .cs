using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionRecursosHumanos.Models
{
	public class CapacitacionCreacionViewModel : Capacitacion
	{
		public IEnumerable<SelectListItem> Departamentos { get; set; }

		public IEnumerable<SelectListItem> Empleados { get; set; }
	}
}
