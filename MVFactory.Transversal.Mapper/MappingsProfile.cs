using System;
using AutoMapper;
using MVFactory.Aplicacion.DTO;
using MVFactory.Domain.Entity;


namespace MVFactory.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {

        public MappingsProfile()
        {
     
            CreateMap<Users, UsersDto>().ReverseMap(); 
            CreateMap<Ciudades, CiudadesDTO>().ReverseMap();
            CreateMap<Pais, PaisDTO>().ReverseMap();
            CreateMap<ClimasHistorico, ClimaHistoricoDTO>().ReverseMap();

            CreateMap<ClimaHistoricoGrilla, ClimaHistoricoGrillaDTO>().ReverseMap();






        }

    }
}
