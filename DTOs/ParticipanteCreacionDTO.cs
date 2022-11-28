using System.ComponentModel.DataAnnotations;

namespace WebApiCasino.DTOs
{
    public class ParticipanteCreacionDTO
    {
        [Required]
        public string NombreParticipante { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Tarjeta { get; set; }
    }
}
