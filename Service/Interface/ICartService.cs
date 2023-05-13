using static EasyShop.Context.DTO.CartDto;

namespace EasyShop.Service.Interface
{
    public interface ICartService
    {
        Task<IEnumerable<CartReadDTO>> GetAllAsync();
        Task<CartReadDTO> GetByIdAsync(int id);
        Task AddAsync(CartCreateDTO supplierDTO);
        Task UpdateAsync(CartUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
