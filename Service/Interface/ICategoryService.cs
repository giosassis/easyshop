using static EasyShop.Context.DTO.CategoryDto;

namespace EasyShop.Service.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryReadDTO>> GetAllAsync();
        Task<CategoryReadDTO> GetByIdAsync(int id);
        Task AddAsync(CategoryCreateDTO supplierDTO);
        Task UpdateAsync(CategoryUpdateDTO supplierDTO);
        Task DeleteAsync(int id);
    }
}
