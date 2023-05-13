using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DataContext _dbContext;

        public AdminRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Admin>> GetAllAsync()
        {
            return await _dbContext.Set<Admin>().ToListAsync();
        }

        public async Task<Admin> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Admin>().FindAsync(id);
        }

        public async Task AddAsync(Admin admin)
        {
            await _dbContext.Set<Admin>().AddAsync(admin);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Admin admin)
        {
            _dbContext.Entry(admin).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Admin admin)
        {
            _dbContext.Set<Admin>().Remove(admin);
            await _dbContext.SaveChangesAsync();
        }
    }
}
