using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Employers.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;

namespace JobLeet.WebApi.JobLeetInfrastructure.Repositories.Employers.V1
{
    public class EmployersRepository : IEmployerRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
       // private readonly BaseDBContext _dbContext;

        // public EmployersRepository(BaseDBContext dbContext)
        // {
        //     _dbContext = dbContext?? throw new ArgumentNullException(nameof(dbContext));
        // }
        #endregion
        public Task<EmployerModel> AddAsync(Employer entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployerModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employer entity)
        {
            throw new NotImplementedException();
        }
    }
}