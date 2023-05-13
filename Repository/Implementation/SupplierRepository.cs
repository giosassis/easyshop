using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DataContext _dbContext;

        public SupplierRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _dbContext.Set<Supplier>().ToListAsync();
        }

        public async Task<Supplier> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Supplier>().FindAsync(id);
        }

        public async Task AddAsync(Supplier supplier)
        {
            await _dbContext.Set<Supplier>().AddAsync(supplier);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Supplier supplier)
        {
            _dbContext.Entry(supplier).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Supplier supplier)
        {
            _dbContext.Set<Supplier>().Remove(supplier);
            await _dbContext.SaveChangesAsync();
        }
    }
}
