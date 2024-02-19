using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class PersonNameRepository : IPersonNameRepository
    {
        private readonly BaseDBContext _dbContext;
        public PersonNameRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<PersonNameModel>> GetAllAsync()
        {
            try
            {
                var result = await _dbContext.PersonNames
                     .Select(e => new PersonNameModel
                     {
                       Id = e.Id,
                       FirstName = e.FirstName,
                       MiddleName = e.MiddleName,
                       LastName = e.LastName
                     }).ToListAsync();
                return result;
            }
            catch(DbUpdateException ex)
            {
                throw new Exception("Error while updating the database. Please try again later." + ex.Message);
            }
        }

        public Task<PersonNameModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PersonNameModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonNameModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
