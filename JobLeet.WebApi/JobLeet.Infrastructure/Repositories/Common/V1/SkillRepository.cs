using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class SkillRepository : ISkillRepository
    {
        private readonly BaseDBContext _dbContext;

        public SkillRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SkillModel>> GetAllAsync()
        {
            try
            {
                var result = await _dbContext.Skills.
                    Select(e => new SkillModel
                    {
                        Id = e.Id,
                        Title = e.Title,
                        Description = e.Description
                    }).ToListAsync();
                return result;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error while updating the database. Please try again later."+ex.Message);
            }
        }

        public Task<SkillModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task AddAsync(SkillModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SkillModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
