using System.ComponentModel.DataAnnotations;
namespace WebApiCasino.DTOs
{
    public class ParticipanteDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} solo puede tener máximo 50 carácteres")]
        public string NombreParticipante { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        [CreditCard]
        public string Tarjeta { get; set; }
    }
}
