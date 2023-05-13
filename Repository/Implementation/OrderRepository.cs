using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dbContext;

        public OrderRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _dbContext.Set<Order>().ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Order>().FindAsync(id);
        }

        public async Task AddAsync(Order order)
        {
            await _dbContext.Set<Order>().AddAsync(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Order order)
        {
            _dbContext.Set<Order>().Remove(order);
            await _dbContext.SaveChangesAsync();
        }
    }
}
