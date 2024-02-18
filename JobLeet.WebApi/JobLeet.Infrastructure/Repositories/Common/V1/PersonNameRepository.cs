using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class PersonNameRepository : IPersonNameRepository
    {
        private readonly DbContext _dbContext;
        public PersonNameRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(PersonNameModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonNameModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PersonNameModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonNameModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
