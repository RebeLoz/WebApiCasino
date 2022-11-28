namespace WebApiCasino.DTOs
{
    public class GetRifaDTO
    {
        public string NombreRifa { get; set; }
        public bool ExistenciaCarta { get; set; }
        public DateTime FechaInicio { get; set; }

        public List <GetPremioDTO> premioList { get; set; }
    }
}
