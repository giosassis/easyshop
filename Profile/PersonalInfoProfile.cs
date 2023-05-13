using AutoMapper;
using EasyShop.Model;
using static EasyShop.Context.DTO.PersonalInfoDto;

namespace webApi.Profiles
{
    public class PersonalInfoProfile : Profile
    {
        public PersonalInfoProfile()
        {
            CreateMap<PersonalInfoCreateDto, PersonalInfo>();
            CreateMap<PersonalInfo, PersonalInfoCreateDto>();
            CreateMap<PersonalInfoReadDto, PersonalInfo>();
            CreateMap<PersonalInfoUpdateDto, PersonalInfo>();
            CreateMap<PersonalInfo, PersonalInfoReadDto>();
            CreateMap<PersonalInfo, PersonalInfoUpdateDto>();
            CreateMap<PersonalInfoCreateDto, PersonalInfoReadDto>();
        }
    }
}