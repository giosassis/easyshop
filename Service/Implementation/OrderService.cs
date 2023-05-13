using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.OrderDto;

namespace EasyShop.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IMapper mapper, IOrderRepository orderRepository )
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderReadDTO>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderReadDTO>>(orders);
        }

        public async Task<OrderReadDTO> GetByIdAsync(int id)
        {
            var orders = await _orderRepository.GetByIdAsync(id);
            return _mapper.Map<OrderReadDTO>(orders);
        }

        public async Task AddAsync(OrderCreateDTO orderCreateDTO)
        {
            var orders = _mapper.Map<Order>(orderCreateDTO);

            orders.OrderDate = DateTime.UtcNow;
            orders.OrderNumber = GenerateOrderNumber();

            await _orderRepository.AddAsync(orders);
        }

        public async Task UpdateAsync(OrderUpdateDTO orderUpdateDTO)
        {
            var orders = _mapper.Map<Order>(orderUpdateDTO);
            await _orderRepository.UpdateAsync(orders);
        }

        public async Task DeleteAsync(int id)
        {
            var orders = await _orderRepository.GetByIdAsync(id);
            await _orderRepository.DeleteAsync(orders);
        }

        private static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1000000, 9999999);
        }

        private static string GenerateOrderNumber()
        {
            var year = DateTime.UtcNow.Year.ToString();
            var randomNumber1 = GenerateRandomNumber().ToString();
            var randomNumber2 = GenerateRandomNumber().ToString();

            return $"{year}-{randomNumber1}-{randomNumber2}";
        }
    }
}
