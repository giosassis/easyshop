using static EasyShop.Context.DTO.ProductDto;

namespace EasyShop.Service.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductReadDto>> GetAllAsync();
        Task<ProductReadDto> GetByIdAsync(int id);
        Task AddAsync(ProductCreateDto supplierDTO);
        Task UpdateAsync(ProductUpdateDto supplierDTO);
        Task DeleteAsync(int id);
    }
}
