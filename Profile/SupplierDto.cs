using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.SupplierDto;

namespace webApi.Profiles
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<CreateSupplierDto, ReadSupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();
            CreateMap<Supplier, CreateSupplierDto>();
            CreateMap<UpdateSupplierDto, Supplier>();
            CreateMap<Supplier, ReadSupplierDto>();
            CreateMap<ReadSupplierDto, Supplier>();
            CreateMap<Supplier, UpdateSupplierDto>();
        }
    }
}
