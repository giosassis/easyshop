using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.BillingInfoDto;

namespace webApi.Profiles;

public class BillingInfoProfile : Profile
{
    public BillingInfoProfile()
    {
        CreateMap<BillingInfoCreateDTO, BillingInfo>();
        CreateMap<BillingInfoCreateDTO, BillingInfoReadDTO>();
        CreateMap<BillingInfo, BillingInfoCreateDTO>();
        CreateMap<BillingInfoUpdateDTO, BillingInfo>();
        CreateMap<BillingInfo, BillingInfoReadDTO>();
        CreateMap<BillingInfoReadDTO, BillingInfo>();
        CreateMap<BillingInfo, BillingInfoUpdateDTO>();
    }
}
