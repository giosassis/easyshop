using static EasyShop.Context.DTO.SubcategoryDto;

namespace EasyShop.Service.Interface
{
    public interface ISubcategoryService
    {
        Task<IEnumerable<SubcategoryReadDto>> GetAllAsync();
        Task<SubcategoryReadDto> GetByIdAsync(int id);
        Task AddAsync(SubcategoryCreateDto supplierDTO);
        Task UpdateAsync(SubcategoryUpdateDto supplierDTO);
        Task DeleteAsync(int id);
    }
}
