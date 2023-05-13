using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.CartDto;

namespace EasyShop.Service.Implementation
{
    public class CartService : ICartService
    {
        private readonly IMapper _mapper;
        private readonly ICartRepository _cartRepository;

        public CartService(IMapper mapper, ICartRepository cartRepository)
        {
            _mapper = mapper;
            _cartRepository = cartRepository;
        }

        public async Task<IEnumerable<CartReadDTO>> GetAllAsync()
        {
            var carts = await _cartRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CartReadDTO>>(carts);
        }

        public async Task<CartReadDTO> GetByIdAsync(int id)
        {
            var cart = await _cartRepository.GetByIdAsync(id);
            return _mapper.Map<CartReadDTO>(cart);
        }

        public async Task AddAsync(CartCreateDTO cartCreateDTO)
        {
            var cart = _mapper.Map<Cart>(cartCreateDTO);

            // validate product and customer existence and prices
            var product = await _cartRepository.GetProductByIdAsync(cart.ProductId);
            if (product == null)
            {
                throw new ArgumentException($"Product with ID {cart.ProductId} not found.");
            }

            var customer = await _cartRepository.GetCustomerByIdAsync(cart.CustomerId);
            if (customer == null)
            {
                throw new ArgumentException($"Customer with ID {cart.CustomerId} not found.");
            }

            var totalPrice = product.Prod_PricePerUnity * cart.Quantity;
            if (totalPrice <= 0)
            {
                throw new ArgumentException("Total price must be positive.");
            }

            cart.TotalPrice = totalPrice;

            await _cartRepository.AddAsync(cart);
        }

        public async Task UpdateAsync(CartUpdateDTO cartUpdateDTO)
        {
            var cart = _mapper.Map<Cart>(cartUpdateDTO);

            // validate product and customer existence and prices
            var product = await _cartRepository.GetProductByIdAsync(cart.ProductId);
            if (product == null)
            {
                throw new ArgumentException($"Product with ID {cart.ProductId} not found.");
            }

            var customer = await _cartRepository.GetCustomerByIdAsync(cart.CustomerId);
            if (customer == null)
            {
                throw new ArgumentException($"Customer with ID {cart.CustomerId} not found.");
            }

            var totalPrice = product.Prod_PricePerUnity * cart.Quantity;
            if (totalPrice <= 0)
            {
                throw new ArgumentException("Total price must be positive.");
            }

            cart.TotalPrice = totalPrice;

            await _cartRepository.UpdateAsync(cart);
        }

        public async Task DeleteAsync(int id)
        {
            var cart = await _cartRepository.GetByIdAsync(id);
            await _cartRepository.DeleteAsync(cart);
        }
    }
}
