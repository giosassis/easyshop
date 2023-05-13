using EasyShop.Model;

namespace EasyShop.Repository.Interface
{
    public interface IBillingInfoRepository
    {
        Task<IEnumerable<Model.BillingInfo>> GetAllAsync();
        Task<Model.BillingInfo> GetByIdAsync(int id);
        Task AddAsync(Model.BillingInfo billingInfo);
        Task UpdateAsync(Model.BillingInfo billingInfo);
        Task DeleteAsync(Model.BillingInfo billingInfo);
    }
}
