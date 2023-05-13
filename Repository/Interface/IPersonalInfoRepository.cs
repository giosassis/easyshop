using EasyShop.Model;

namespace EasyShop.Repository.Interface
{
    public interface IPersonalInfoRepository
    {
        Task<IEnumerable<PersonalInfo>> GetAllAsync();
        Task<PersonalInfo> GetByIdAsync(int id);
        Task AddAsync(PersonalInfo personalInfo);
        Task UpdateAsync(PersonalInfo personalInfo);
        Task DeleteAsync(PersonalInfo personalInfo);
    }
}
