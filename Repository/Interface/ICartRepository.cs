using EasyShop.Model;

namespace EasyShop.Repository.Interface
{
    public interface ICartRepository
    {
        Task<IEnumerable<Cart>> GetAllAsync();
        Task<Cart> GetByIdAsync(int id);
        Task<Product> GetProductByIdAsync(int id);
        Task<Customer> GetCustomerByIdAsync(int id);
        Task AddAsync(Cart cart);
        Task UpdateAsync(Cart cart);
        Task DeleteAsync(Cart cart);
    }
}
