using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.SupplierDto;

namespace EasyShop.Service.Implementation
{
    public class SupplierService : ISupplierService
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(IMapper mapper, ISupplierRepository supplierRepository)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
        }

        public async Task<IEnumerable<ReadSupplierDto>> GetAllAsync()
        {
            var suppliers = await _supplierRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ReadSupplierDto>>(suppliers);
        }

        public async Task<ReadSupplierDto> GetByIdAsync(int id)
        {
            var supplier = await _supplierRepository.GetByIdAsync(id);
            return _mapper.Map<ReadSupplierDto>(supplier);
        }

        public async Task AddAsync(CreateSupplierDto supplierDTO)
        {
            var supplier = _mapper.Map<Supplier>(supplierDTO);
            await _supplierRepository.AddAsync(supplier);
        }

        public async Task UpdateAsync(UpdateSupplierDto supplierDTO)
        {
            var supplier = _mapper.Map<Supplier>(supplierDTO);
            await _supplierRepository.UpdateAsync(supplier);
        }

        public async Task DeleteAsync(int id)
        {
            var supplier = await _supplierRepository.GetByIdAsync(id);
            await _supplierRepository.DeleteAsync(supplier);
        }
    }
}
