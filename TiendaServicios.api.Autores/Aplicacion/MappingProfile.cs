using AutoMapper;
using TiendaServicios.api.Autores.Modelo;

namespace TiendaServicios.api.Autores.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}
