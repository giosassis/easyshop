using AutoMapper;
using EasyShop.Model;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using static EasyShop.Context.DTO.PersonalInfoDto;

namespace EasyShop.Service.Implementation
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly IMapper _mapper;
        private readonly IPersonalInfoRepository _personalInfoRepository ;

        public PersonalInfoService(IMapper mapper, IPersonalInfoRepository personalInfoRepository)
        {
            _mapper = mapper;
            _personalInfoRepository = personalInfoRepository;
        }

        public async Task<IEnumerable<PersonalInfoReadDto>> GetAllAsync()
        {
            var personalInfos = await _personalInfoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PersonalInfoReadDto>>(personalInfos);
        }

        public async Task<PersonalInfoReadDto> GetByIdAsync(int id)
        {
            var personalInfos = await _personalInfoRepository.GetByIdAsync(id);
            return _mapper.Map<PersonalInfoReadDto>(personalInfos);
        }

        public async Task AddAsync(PersonalInfoCreateDto personalInfoCreateDto )
        {
            var personalInfos = _mapper.Map<PersonalInfo>(personalInfoCreateDto);
            await _personalInfoRepository.AddAsync(personalInfos);
        }

        public async Task UpdateAsync(PersonalInfoUpdateDto personalInfoUpdateDto )
        {
            var personalInfos = _mapper.Map<PersonalInfo>(personalInfoUpdateDto);
            await _personalInfoRepository.UpdateAsync(personalInfos);
        }

        public async Task DeleteAsync(int id)
        {
            var personalInfos = await _personalInfoRepository.GetByIdAsync(id);
            await _personalInfoRepository.DeleteAsync(personalInfos);
        }
    }
}
