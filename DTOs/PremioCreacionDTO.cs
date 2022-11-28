using System.ComponentModel.DataAnnotations;
using WebApiCasino.Entidades;

namespace WebApiCasino.DTOs
{
    public class PremioCreacionDTO
    {
        [Required]
        public int idRifa { get; set; }
        [Required]
        public string premio { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        public int numpremio { get; set; }

        public Rifa Rifa { get; set; }
    }
}
