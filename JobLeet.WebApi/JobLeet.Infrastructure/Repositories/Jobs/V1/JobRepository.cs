using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Jobs.V1
{

    public class JobRepository : IJobRepository
    {
        #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public JobRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<JobModel> AddAsync(JobEntity entity)
        {
            try
            {

                var job = new JobEntity
                {
                    JobAddress = new()
                    {
                        Street = entity?.JobAddress?.Street,
                        City = entity?.JobAddress?.City,
                        State = entity?.JobAddress?.State,
                        PostalCode = entity?.JobAddress?.PostalCode,
                        Country = entity?.JobAddress?.Country

                    },
                    RequiredQualification = new()
                    {
                        QualificationType = entity.RequiredQualification.QualificationType,
                        QualificationInformation = entity.RequiredQualification.QualificationInformation
                    },
                    JobTitle = entity.JobTitle,
                    JobDescription = entity.JobDescription,
                    Vacancies = entity.Vacancies,
                    RequiredExperience = new()
                    {
                        ExperienceLevel = entity.RequiredExperience.ExperienceLevel
                    },
                    BasicPay = entity.BasicPay,
                    FunctionalArea = entity.FunctionalArea,
                    IndustryType = new()
                    {
                        IndustryCategory = entity.IndustryType.IndustryCategory
                    },
                    PostingDate = entity.PostingDate
                };

                _dbContext.JobEntity.Add(job);

                // Api response
                var jobResponse = new JobModel
                {
                    Id = job.Id,
                    JobAddress = new()
                    {
                        Street = job.JobAddress.Street,
                        City = job.JobAddress.City,
                        State = job.JobAddress.State,
                        PostalCode = job.JobAddress.PostalCode,
                        Country = job.JobAddress.Country
                    },
                    RequiredQualification = new()
                    {
                        QualificationType = (Api.Models.Common.V1.QualificationCategory)job.RequiredQualification.QualificationType,
                        QualificationInformation = job.RequiredQualification.QualificationInformation
                    },
                    JobTitle = job.JobTitle,
                    JobDescription = job.JobDescription,
                    Vacancies = job.Vacancies,

                    RequiredExperience = new()
                    {
                        ExperienceLevel = (Api.Models.Common.V1.ExperienceLevel)job.RequiredExperience.ExperienceLevel
                    },
                    BasicPay = job.BasicPay,
                    FunctionalArea = job.FunctionalArea,
                    IndustryType = new()
                    {
                        IndustryCategory = (Api.Models.Companies.V1.IndustryCategory)job.IndustryType.IndustryCategory
                    },
                    PostingDate = job.PostingDate

                };
                return jobResponse;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while logging in: {ex.Message}");
            }
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JobModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<JobModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(JobEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}