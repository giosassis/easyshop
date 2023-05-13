using static EasyShop.Context.DTO.PersonalInfoDto;

namespace EasyShop.Service.Interface
{
    public interface IPersonalInfoService
    {
        Task<IEnumerable<PersonalInfoReadDto>> GetAllAsync();
        Task<PersonalInfoReadDto> GetByIdAsync(int id);
        Task AddAsync(PersonalInfoCreateDto supplierDTO);
        Task UpdateAsync(PersonalInfoUpdateDto supplierDTO);
        Task DeleteAsync(int id);
    }
}
