using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Mappers.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeetInfrastructure.Repositories.Companies.V1{

    public class ApplicationRepository : IApplicationRepository
    {
         #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public ApplicationRepository(BaseDBContext dbContext){

            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<ApplicationModel> AddAsync(Application entity)
        {
            try{
                
                if (entity == null){
                    throw new ArgumentNullException(nameof(entity));
                }

                var saveToDb = ApplicationMapper.ToApplicationDataBase(entity);
                await _dbContext.Applications.AddAsync(saveToDb);
                await _dbContext.SaveChangesAsync();
                
                var apiResponse = ApplicationMapper.ToApplicationModel(saveToDb);
                return apiResponse;
            }
            catch(Exception ex){
                throw new Exception("Error adding company", ex);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationModel>> GetAllAsync()
        {
            try{

            var applications = await _dbContext.Applications.ToListAsync();
            return applications.Select(ApplicationMapper.ToApplicationModel).ToList();
            }
            catch(Exception ex){
                throw new Exception("Error Retriving Application", ex);
            }
        }

        public Task<ApplicationModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Application entity)
        {
            throw new NotImplementedException();
        }
    }
}