using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.OrderDto;

namespace webApi.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderCreateDTO, Order>();
            CreateMap<OrderCreateDTO, OrderReadDTO>();
            CreateMap<OrderUpdateDTO, Order>();
            CreateMap<Order, OrderReadDTO>();
            CreateMap<Order, OrderUpdateDTO>();
            CreateMap<Order, OrderCreateDTO>();
            CreateMap<OrderReadDTO, Order>();
        }
    }
}

