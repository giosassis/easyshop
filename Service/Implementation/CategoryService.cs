using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.CategoryDto;

namespace EasyShop.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryReadDTO>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryReadDTO>>(categories);
        }

        public async Task<CategoryReadDTO> GetByIdAsync(int id)
        {
            var categories = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryReadDTO>(categories);
        }

        public async Task AddAsync(CategoryCreateDTO categoryCreateDTO)
        {
            var categories = _mapper.Map<Category>(categoryCreateDTO);
            await _categoryRepository.AddAsync(categories);
        }

        public async Task UpdateAsync(CategoryUpdateDTO categoryUpdateDTO)
        {
            var categories = _mapper.Map<Category>(categoryUpdateDTO);
            await _categoryRepository.UpdateAsync(categories);
        }

        public async Task DeleteAsync(int id)
        {
            var categories = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(categories);
        }
    }
}
