using AutoMapper;
using static EasyShop.Context.DTO.CategoryDto;
using EasyShop.Model;

namespace webApi.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CategoryCreateDTO, Category>();
        CreateMap<CategoryCreateDTO, CategoryReadDTO>();
        CreateMap<CategoryUpdateDTO, Category>();
        CreateMap<Category, CategoryReadDTO>();
        CreateMap<Category, CategoryCreateDTO>();
        CreateMap<CategoryReadDTO, Category>();
        CreateMap<Category, CategoryUpdateDTO>();
    }
}