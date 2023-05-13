using EasyShop.Model;

namespace EasyShop.Repository.Interface
{
    public interface ISubcategoryRepository
    {
        Task<IEnumerable<Subcategory>> GetAllAsync();
        Task<Subcategory> GetByIdAsync(int id);
        Task AddAsync(Subcategory subcategory);
        Task UpdateAsync(Subcategory subcategory);
        Task DeleteAsync(Subcategory subcategory);
    }
}
