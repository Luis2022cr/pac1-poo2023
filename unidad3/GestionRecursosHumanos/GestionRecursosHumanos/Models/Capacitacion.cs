using GestionRecursosHumanos.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace GestionRecursosHumanos.Models
{
	public class Capacitacion
	{
		public int Id { get; set; }
		
		public int UsuarioId { get; set; }
		[Required(ErrorMessage = "El {0} es requerido.")]
		[PrimeraLetraMayuscula]
		public string Nombre { get; set; }
		[Display(Name = "Departamento")]
		public int DepartamentoId { get; set; }

		public string Departamento { get; set; }
        [Required(ErrorMessage = "La {0} es requerida.")]
        public DateTime Fecha { get; set; }
		[Display(Name = "Duracion en Horas")]
		[Required(ErrorMessage = "La {0} es requerida.")]
        public int Duracion { get; set; }
        [Required(ErrorMessage = "EL {0} es requerido.")]
        public int Costo { get; set; }
        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "EL {0} es requerido.")]
        public int EmpleadoId { get; set; }

		public string Empleado { get; set; }
		[StringLength(maximumLength: 50, MinimumLength = 0, ErrorMessage = "El campo {0} debe de tener entre {2} y {1} letras")]
		public string Descripcion { get; set; }
	}
}
