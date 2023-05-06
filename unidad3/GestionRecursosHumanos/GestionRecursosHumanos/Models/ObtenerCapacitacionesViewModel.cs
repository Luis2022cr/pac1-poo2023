namespace GestionRecursosHumanos.Models
{
	public class CapacitacionDTO
	{
		public int Id { get; set; }

		public string Nombre { get; set; }

		public DateTime Fecha { get; set; }

		public string NombreDepartamento { get; set; }

		public string NombreEmpleado { get; set; }

		public int Duracion { get; set; }

		public int Costo { get; set; }

		public string Descripcion { get; set; }
	}

	public class ObtenerCapacitacionesViewModel
	{
		public IEnumerable<CapacitacionDTO> Capacitaciones { get; set; }
	}
}
