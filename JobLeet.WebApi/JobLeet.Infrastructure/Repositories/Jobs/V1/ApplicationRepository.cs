using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Mappers.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeetInfrastructure.Repositories.Companies.V1
{

    public class ApplicationRepository : IApplicationRepository
    {
        #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public ApplicationRepository(BaseDBContext dbContext)
        {

            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<ApplicationModel> AddAsync(Application entity)
        {
            try
            {

                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                var saveToDb = ApplicationMapper.ToApplicationDataBase(entity);
                await _dbContext.Applications.AddAsync(saveToDb);
                await _dbContext.SaveChangesAsync();

                var apiResponse = ApplicationMapper.ToApplicationModel(saveToDb);
                return apiResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding company", ex);
            }
        }

        public async Task<Application> ApplyForJobAsync(int seekerId, int jobId, int companyId)
        {
            try{
                 if (seekerId <= 0 || jobId <= 0)
            {
                throw new ArgumentException("Seeker ID and Job ID must be greater than zero.");
            }

            var seeker = await _dbContext.Seekers.FindAsync(seekerId);
            if(seeker == null){
                throw new Exception($"Seeker with ID {seekerId} not found");
            }
            
            var company = await _dbContext.Companies.FindAsync(companyId);
            if(company == null){
                 throw new Exception($"Company with ID {companyId} not found");
            }
            var job = await _dbContext.Jobs.Include(j => j.CompanyDescription).FirstOrDefaultAsync(j => j.Id == jobId);

            if(job == null){
                throw new Exception($"Job with ID {jobId} not found.");
            }

            var existingApplication = await _dbContext.Applications.FirstOrDefaultAsync(a => a.SeekerId == seekerId && a.JobId == jobId);
            if(existingApplication != null){

                throw new Exception("Seeker has already applied for this job.");
            }
            var application = new Application
            {
                SeekerId = seekerId,
                Seekers = seeker,
                CompanyId = job.CompanyDescription.Id,
                Company = company,
                JobId = jobId,
                Jobs = job,
            };

                await _dbContext.Applications.AddAsync(application);
                await _dbContext.SaveChangesAsync();
                return application;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while applying for the job.", ex);
            }
           

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationModel>> GetAllAsync()
        {
            try
            {

                var applications = await _dbContext.Applications.ToListAsync();
                return applications.Select(ApplicationMapper.ToApplicationModel).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Retriving Application", ex);
            }
        }

        public Task<ApplicationModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Application> UpdateApplicationStatusAsync(int applicationId, Status status)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Application entity)
        {
            throw new NotImplementedException();
        }
    }
}