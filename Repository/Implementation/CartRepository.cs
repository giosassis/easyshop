using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class CartRepository : ICartRepository
    {
        private readonly DataContext _dbContext;

        public CartRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return await _dbContext.Set<Cart>().ToListAsync();
        }

        public async Task<Cart> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Cart>().FindAsync(id);
        }

        public async Task AddAsync(Cart cart)
        {
            await _dbContext.Set<Cart>().AddAsync(cart);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cart cart)
        {
            _dbContext.Entry(cart).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Cart cart)
        {
            _dbContext.Set<Cart>().Remove(cart);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _dbContext.Set<Product>().FindAsync(id);
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _dbContext.Set<Customer>().FindAsync(id);
        }
    }
}
