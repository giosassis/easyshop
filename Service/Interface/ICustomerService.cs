using static EasyShop.Context.DTO.CustomerDto;

namespace EasyShop.Service.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerReadDTO>> GetAllAsync();
        Task<CustomerReadDTO> GetByIdAsync(int id);
        Task AddAsync(CustomerCreateDTO supplierDTO);
        Task UpdateAsync(CustomerUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
