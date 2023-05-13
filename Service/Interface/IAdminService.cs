using static EasyShop.Context.DTO.AdminDTO;

namespace EasyShop.Service.Interface
{
    public interface IAdminService
    {
        Task<IEnumerable<AdminReadDTO>> GetAllAsync();
        Task<AdminReadDTO> GetByIdAsync(int id);
        Task AddAsync(AdminCreateDTO supplierDTO);
        Task UpdateAsync(AdminUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
