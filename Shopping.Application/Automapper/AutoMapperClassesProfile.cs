using AutoMapper;
using Shopping.Application.DTOs;
using Shopping.Domain.Entities;


namespace Shopping.Application.Automapper
{
    public class AutoMapperClassesProfile : Profile
    {
        public AutoMapperClassesProfile()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<ProductDto, Product>();

        }
    }
}
