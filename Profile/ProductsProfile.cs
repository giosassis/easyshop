using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.ProductDto;

public class ProductsProfile : Profile
{
    public ProductsProfile()
    {
        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductCreateDto, ProductReadDto>();
        CreateMap<Product, ProductCreateDto>();
        CreateMap<Product, ProductUpdateDto>();
        CreateMap<ProductUpdateDto, Product>();
        CreateMap<Product, ProductReadDto>();
        CreateMap<ProductReadDto, Product>();
    }
}