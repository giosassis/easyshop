using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.ProductDto;

namespace EasyShop.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductReadDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductReadDto>>(products);
        }

        public async Task<ProductReadDto> GetByIdAsync(int id)
        {
            var products = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductReadDto>(products);
        }

        public async Task AddAsync(ProductCreateDto productCreateDto)
        {
            var product = _mapper.Map<Product>(productCreateDto);

            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;

            await _productRepository.AddAsync(product);
        }

        public async Task UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            var products = _mapper.Map<Product>(productUpdateDto);
            await _productRepository.UpdateAsync(products);
        }

        public async Task DeleteAsync(int id)
        {
            var supplier = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(supplier);
        }
    }
}
