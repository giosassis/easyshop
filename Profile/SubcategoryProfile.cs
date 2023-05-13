using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.SubcategoryDto;

namespace webApi.Profiles
{
    public class SubcategoryProfile : Profile
    {
        public SubcategoryProfile()
        {
            CreateMap<SubcategoryCreateDto, SubcategoryReadDto>();
            CreateMap<SubcategoryCreateDto, Subcategory>();
            CreateMap<Subcategory, SubcategoryCreateDto>();
            CreateMap<SubcategoryUpdateDto, Subcategory>();
            CreateMap<Subcategory, SubcategoryReadDto>();
            CreateMap<SubcategoryReadDto, Subcategory>();
            CreateMap<Subcategory, SubcategoryUpdateDto>();
        }
    }
}
