using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50,
            MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        [Display(Name = "Tipo Cuenta")]
        public int TipoCuentaId { get; set; }
        public decimal Balance { get; set; }

        [StringLength(maximumLength: 1000, ErrorMessage = "muchas palabras")]
        public string Descripcion { get; set; }

        public String TipoCuenta { get; set; }

    }
}
