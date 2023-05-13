using EasyShop.Context;
using EasyShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Repository.Interface
{
    public class PersonalInfoRepository : IPersonalInfoRepository
    {
        private readonly DataContext _dbContext;

        public PersonalInfoRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PersonalInfo>> GetAllAsync()
        {
            return await _dbContext.Set<PersonalInfo>().ToListAsync();
        }

        public async Task<PersonalInfo> GetByIdAsync(int id)
        {
            return await _dbContext.Set<PersonalInfo>().FindAsync(id);
        }

        public async Task AddAsync(PersonalInfo personalInfo)
        {
            await _dbContext.Set<PersonalInfo>().AddAsync(personalInfo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(PersonalInfo personalInfo)
        {
            _dbContext.Entry(personalInfo).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(PersonalInfo personalInfo)
        {
            _dbContext.Set<PersonalInfo>().Remove(personalInfo);
            await _dbContext.SaveChangesAsync();
        }
    }
}
