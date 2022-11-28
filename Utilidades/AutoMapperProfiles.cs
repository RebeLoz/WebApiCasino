using AutoMapper;
using WebApiCasino.DTOs;
using WebApiCasino.Entidades;

namespace WebApiCasino.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RifaCreacionDTO, RifaDTO>();
            CreateMap<RifaDTO, Rifa>();
            CreateMap<Rifa, GetRifaDTO>();
                //.ForMember(getrifaDTO => getrifaDTO.premioList, opciones => opciones.MapFrom(MapRifaGetRifaDTO)); me quede en esto
            CreateMap<Rifa, RifaPatchDTO>().ReverseMap();

            CreateMap<PremioCreacionDTO, PremioDTO>();
            CreateMap<PremioDTO, Premio>();

            CreateMap<ParticipanteCreacionDTO, Participante>();
            CreateMap<Participante, ParticipanteDTO>();

            //CreateMap<CartaCreacionDTO, Carta>(); no se si crear la cartacreaciondto :c soy lloros
            CreateMap<Carta, CartaDTO>();

            //CreateMap<ParticipanteRifaCartaCreacionDTO, ParticipanteRifaCarta>(); tampoco supe si crearla xd
            CreateMap<ParticipanteRifaCartaDTO, ParticipanteRifaCarta>().ReverseMap();
        }
    }
}