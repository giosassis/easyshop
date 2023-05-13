using static EasyShop.Context.DTO.BillingInfoDto;

namespace EasyShop.Service.Interface
{
    public interface IBillingInfoService
    {
        Task<IEnumerable<BillingInfoReadDTO>> GetAllAsync();
        Task<BillingInfoReadDTO> GetByIdAsync(int id);
        Task AddAsync(BillingInfoCreateDTO supplierDTO);
        Task UpdateAsync(BillingInfoUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
