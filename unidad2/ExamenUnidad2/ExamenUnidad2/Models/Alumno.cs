using System.ComponentModel.DataAnnotations;

namespace ExamenUnidad2.Models
{
    public class Alumno
    {
		[Required(ErrorMessage = "Escriba un nombre")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "Escriba su Apellido")]
        public string Apellido { get; set; }
		[Required(ErrorMessage = "Escriba el numero de cuenta")]
        public string NumeroDeCuenta { get; set; }

        public bool Presente { get; set; }
		public bool Ausente { get; set; }
	}
}
