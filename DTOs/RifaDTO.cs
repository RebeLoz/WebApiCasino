using System.ComponentModel.DataAnnotations;
using WebApiCasino.Validaciones;

namespace WebApiCasino.DTOs
{
    public class RifaDTO
    {
        public string NombreRifa { get; set; }
        public bool ExistenciaCarta { get; set; }
        public DateTime FechaInicio { get; set; }
    }
}
