using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Companies.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Mappers.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeetInfrastructure.Repositories.Companies.V1{

    public class CompanyRepository : ICompanyRepository
    {
         #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public CompanyRepository(BaseDBContext dbContext){

            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<CompanyModel> AddAsync(Company entity)
        {
            try{
                
                await _dbContext.Companies.AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                if (entity == null){
                    throw new ArgumentNullException(nameof(entity));
                }

                var companyModel = CompanyMapper.ToCompanyModel(entity);
                return companyModel;
            }
            catch(Exception ex){
                throw new Exception("Error adding company", ex);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CompanyModel>> GetAllAsync()
        {
            try{

            var companies = await _dbContext.Companies.ToListAsync();
            return companies.Select(CompanyMapper.ToCompanyModel).ToList();
            }
            catch(Exception ex){
                throw new Exception("Error Retriving company", ex);
            }
        }

        public Task<CompanyModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}