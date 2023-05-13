using EasyShop.Context.DTO;
using static EasyShop.Context.DTO.SupplierDto;

namespace EasyShop.Service.Interface
{
    public interface ISupplierService
    {
        Task<IEnumerable<ReadSupplierDto>> GetAllAsync();
        Task<ReadSupplierDto> GetByIdAsync(int id);
        Task AddAsync(CreateSupplierDto supplierDTO);
        Task UpdateAsync(UpdateSupplierDto supplierDTO);
        Task DeleteAsync(int id);
    }
}
