using System.ComponentModel.DataAnnotations;
using WebApiCasino.Validaciones;

namespace WebApiCasino.Entidades
{
    public class Rifa
    {
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} solo puede tener hasta 50 caracteres.")]
        [PrimerLetraMayuscula]
        public string NombreRifa { get; set; }
        [Required]
        public bool ExistenciaCarta { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }

        public List<ParticipanteRifaCarta> ParticipanteRifaCartas { get; set; }
        public List<Premio> Premios { get; set; }
    }
}
