using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.AdminDTO;

public class AdminProfile : Profile
{
    public AdminProfile()
    {
        CreateMap<AdminCreateDTO, Admin>();
        CreateMap<AdminCreateDTO, AdminReadDTO>();
        CreateMap<Admin, AdminCreateDTO>();
        CreateMap<Admin, AdminUpdateDTO>();
        CreateMap<AdminUpdateDTO, Admin>();
        CreateMap<Admin, AdminReadDTO>();
        CreateMap<AdminReadDTO, Admin>();
    }
}