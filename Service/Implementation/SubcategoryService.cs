using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.SubcategoryDto;

namespace EasyShop.Service.Implementation
{
    public class SubcategoryService : ISubcategoryService
    {
        private readonly IMapper _mapper;
        private readonly ISubcategoryRepository _subcategoryRepository;

        public SubcategoryService(IMapper mapper, ISubcategoryRepository subcategoryRepository)
        {
            _mapper = mapper;
            _subcategoryRepository = subcategoryRepository;
        }

        public async Task<IEnumerable<SubcategoryReadDto>> GetAllAsync()
        {
            var subcategories = await _subcategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<SubcategoryReadDto>>(subcategories);
        }

        public async Task<SubcategoryReadDto> GetByIdAsync(int id)
        {
            var subcategories = await _subcategoryRepository.GetByIdAsync(id);
            return _mapper.Map<SubcategoryReadDto>(subcategories);
        }

        public async Task AddAsync(SubcategoryCreateDto subcategoryCreateDto)
        {
            var subcategories = _mapper.Map<Subcategory>(subcategoryCreateDto);
            await _subcategoryRepository.AddAsync(subcategories);
        }

        public async Task UpdateAsync(SubcategoryUpdateDto subcategoryUpdateDto)
        {
            var subcategories = _mapper.Map<Subcategory>(subcategoryUpdateDto);
            await _subcategoryRepository.UpdateAsync(subcategories);
        }

        public async Task DeleteAsync(int id)
        {
            var subcategories = await _subcategoryRepository.GetByIdAsync(id);
            await _subcategoryRepository.DeleteAsync(subcategories);
        }
    }
}
