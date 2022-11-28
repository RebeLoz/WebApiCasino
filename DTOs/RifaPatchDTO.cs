using System.ComponentModel.DataAnnotations;
using WebApiCasino.Validaciones;

namespace WebApiCasino.DTOs
{
    public class RifaPatchDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "El campo {0} solo puede tener hasta 70 caracteres.")]
        [PrimerLetraMayuscula]
        public string NombreRifa { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public bool ExistenciaCarta { get; set; }
    }
}
