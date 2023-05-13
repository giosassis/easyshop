using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class BillingRepository : IBillingInfoRepository
    {
        private readonly DataContext _dbContext;

        public BillingRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<BillingInfo>> GetAllAsync()
        {
            return await _dbContext.Set<BillingInfo>().ToListAsync();
        }

        public async Task<BillingInfo> GetByIdAsync(int id)
        {
            return await _dbContext.Set<BillingInfo>().FindAsync(id);
        }

        public async Task AddAsync(BillingInfo billingInfo)
        {
            await _dbContext.Set<BillingInfo>().AddAsync(billingInfo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(BillingInfo billingInfo)
        {
            _dbContext.Entry(billingInfo).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(BillingInfo billingInfo)
        {
            _dbContext.Set<BillingInfo>().Remove(billingInfo);
            await _dbContext.SaveChangesAsync();
        }
    }
}
