using static EasyShop.Context.DTO.OrderDto;

namespace EasyShop.Service.Interface
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderReadDTO>> GetAllAsync();
        Task<OrderReadDTO> GetByIdAsync(int id);
        Task AddAsync(OrderCreateDTO supplierDTO);
        Task UpdateAsync(OrderUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
