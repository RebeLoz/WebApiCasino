using System.ComponentModel.DataAnnotations;

namespace WebApiCasino.DTOs
{
    public class GetPremioDTO
    {
        public string premio { get; set; }
        public string descripcion { get; set; }
        public int numpremio { get; set; }
    }
}
