using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.CustomerDto;

namespace webApi.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CustomerCreateDTO, Customer>(); ;
        CreateMap<CustomerCreateDTO, CustomerReadDTO>();
        CreateMap<Customer, CustomerCreateDTO>();
        CreateMap<Customer, CustomerUpdateDTO>();
        CreateMap<CustomerUpdateDTO, Customer>();
        CreateMap<Customer, CustomerReadDTO>();
        CreateMap<CustomerReadDTO, Customer>();
    }
}
