using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly DataContext _dbContext;

        public SubcategoryRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Subcategory>> GetAllAsync()
        {
            return await _dbContext.Set<Subcategory>().ToListAsync();
        }

        public async Task<Subcategory> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Subcategory>().FindAsync(id);
        }

        public async Task AddAsync(Subcategory subcategory)
        {
            await _dbContext.Set<Subcategory>().AddAsync(subcategory);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Subcategory subcategory)
        {
            _dbContext.Entry(subcategory).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Subcategory subcategory)
        {
            _dbContext.Set<Subcategory>().Remove(subcategory);
            await _dbContext.SaveChangesAsync();
        }
    }
}
