using APIPelisPlus.Models;
using APIPelisPlus.Models.Dtos;
using AutoMapper;

namespace APIPelisPlus.PeliculasMapper
{
    public class PeliculasMappers : Profile
    {
        public PeliculasMappers()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }
    }
}
