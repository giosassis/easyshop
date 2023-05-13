using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EasyShop.Repository.Interface
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dbContext;

        public CustomerRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _dbContext.Set<Customer>().ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Customer>().FindAsync(id);
        }

        public async Task<bool> GetByUsernameAsync (string username)
        {
            return await _dbContext.Customers.AnyAsync(c => c.Username == username);
        }

        public async Task AddAsync(Customer customer)
        {
            await _dbContext.Set<Customer>().AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer customer)
        {
            _dbContext.Set<Customer>().Remove(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}
