using GestionRecursosHumanos.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GestionRecursosHumanos.Models
{
	public class Cargo
	{
		public int Id { get; set; }
		[Display(Name = "Nombre")]
		[Required(ErrorMessage = "El {0} es requerido.")]
		[PrimeraLetraMayuscula]
		[Remote(action: "VerificarExisteCargo", "Cargos")]
		[StringLength(maximumLength: 50, MinimumLength = 0, ErrorMessage = "El campo {0} debe de tener entre {2} y {1} letras")]
		public string Nombre { get; set; }
		public int UsuarioId { get; set; }
		[Display(Name = "Codigo")]
		[StringLength(maximumLength: 20, MinimumLength = 0, ErrorMessage = "El campo {0} debe de tener entre {2} y {1} letras")]
		[Required(ErrorMessage = "El {0} es requerido.")]
		public string Codigo { get; set; }
		[StringLength(maximumLength: 50, MinimumLength = 0, ErrorMessage = "El campo {0} debe de tener entre {2} y {1} letras")]
		public string Descripcion { get; set; }
	}
}
