using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
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
                #region  To JobLeet DB
                var job = new JobEntity
                {
                    CompanyDescription = new(){
                        
                        CompanyName = entity.CompanyDescription.CompanyName,
                        Profile = new(){
                            ProfileInfo = entity.CompanyDescription.Profile.ProfileInfo,
                            CompanyAddress = new(){
                                // Headquater of the Company
                                Street = entity.CompanyDescription.Profile.CompanyAddress.State,
                                City = entity.CompanyDescription.Profile.CompanyAddress.City,
                                State = entity.CompanyDescription.Profile.CompanyAddress.State,
                                PostalCode = entity.CompanyDescription.Profile.CompanyAddress.PostalCode,
                                Country = entity.CompanyDescription.Profile.CompanyAddress.Country
                            },

                            ContactPhone = new(){
                                CountryCode = entity.CompanyDescription.Profile.ContactPhone.CountryCode,
                                PhoneNumber = entity.CompanyDescription.Profile.ContactPhone.PhoneNumber
                            },
                            ContactEmail = new(){
                                EmailType = entity.CompanyDescription.Profile.ContactEmail.EmailType,
                                EmailAddress = entity.CompanyDescription.Profile.ContactEmail.EmailAddress
                            },
                            Website = entity.CompanyDescription.Profile.Website,
                            IndustryType = entity.CompanyDescription.Profile.IndustryType
                        }
                    },
                    JobTitle = entity.JobTitle,
                    JobDescription = entity.JobDescription,
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
                    JobType = entity.JobType,
                    Vacancies = entity.Vacancies,
                    SkillsRequired = new () {
                        Title = entity?.SkillsRequired?.Title,
                        Description = entity?.SkillsRequired?.Description
                    },
                    RequiredExperience = new()
                    {
                        ExperienceLevel = entity.RequiredExperience.ExperienceLevel
                    },
                    BasicPay = new(){
                        MinmumPay = entity.BasicPay.MinmumPay,
                        MaximumPay = entity.BasicPay.MaximumPay,
                        Currency = entity.BasicPay.Currency
                    },
                    PreferredQualifications = entity.PreferredQualifications,
                    JobResponsibilities = entity.JobResponsibilities,
                    Benefits = entity.Benefits,
                    FunctionalArea = entity.FunctionalArea,
                    WorkEnvironment = entity.WorkEnvironment,
                    Tags = entity.Tags,
                    PostingDate = entity.PostingDate,
                    ApplicationDeadline = entity.ApplicationDeadline
                };

                _dbContext.JobEntity.Add(job);
                 await _dbContext.SaveChangesAsync();
                #endregion

                #region  To Api Response
                var jobResponse = new JobModel
                {
                    Id = job.Id,
                    JobTitle = job.JobTitle,
                    JobDescription = job.JobDescription,
                    JobType = job.JobType,
                    CompanyDescription = new(){
                        Id = job.CompanyDescription.Id,
                        CompanyName = job.CompanyDescription.CompanyName,
                        Profile = new(){
                            ProfileInfo = entity.CompanyDescription.Profile.ProfileInfo,
                            CompanyAddress = new(){
                                // Headquater of the Company
                                Id = job.CompanyDescription.Profile.CompanyAddress.Id,
                                Street = job.CompanyDescription.Profile.CompanyAddress.State,
                                City = job.CompanyDescription.Profile.CompanyAddress.City,
                                State = job.CompanyDescription.Profile.CompanyAddress.State,
                                PostalCode = job.CompanyDescription.Profile.CompanyAddress.PostalCode,
                                Country = job.CompanyDescription.Profile.CompanyAddress.Country
                            },

                            ContactPhone = new(){
                                CountryCode = job.CompanyDescription.Profile.ContactPhone.CountryCode,
                                PhoneNumber = job.CompanyDescription.Profile.ContactPhone.PhoneNumber,
                                Id = job.CompanyDescription.Profile.ContactPhone.Id
                            },
                            ContactEmail = new(){
                                EmailType = (Api.Models.Common.V1.EmailCategory)job.CompanyDescription.Profile.ContactEmail.EmailType,
                                EmailAddress = job.CompanyDescription.Profile.ContactEmail.EmailAddress,
                                Id = job.CompanyDescription.Profile.ContactEmail.Id
                            },
                            Website = job.CompanyDescription.Profile.Website,
                            IndustryType = (IndustryCategory)job.CompanyDescription.Profile.IndustryType,
                            Id = job.CompanyDescription.Profile.Id
                        }
                    },
                    JobAddress = new()

                    {
                        Id = job.JobAddress.Id,
                        Street = job.JobAddress.Street,
                        City = job.JobAddress.City,
                        State = job.JobAddress.State,
                        PostalCode = job.JobAddress.PostalCode,
                        Country = job.JobAddress.Country
                    },
                    Vacancies = job.Vacancies,
                    BasicPay = new(){
                        MinmumPay  = job.BasicPay.MinmumPay,
                        MaximumPay = job.BasicPay.MaximumPay,
                        Currency = job.BasicPay.Currency
                    },
                    FunctionalArea = job.FunctionalArea,
                    SkillsRequired = new(){
                        Id = job.SkillsRequired.Id,
                        Title = job.SkillsRequired.Title,
                        Description = job.SkillsRequired.Description
                    },
                    RequiredQualification = new()
                    {
                        Id = job.RequiredQualification.Id,
                        QualificationType = (Api.Models.Common.V1.QualificationCategory)job.RequiredQualification.QualificationType,
                        QualificateionInformation= job.RequiredQualification.QualificationInformation
                    },
                    
                    RequiredExperience = new()
                    {
                        Id = job.RequiredExperience.Id,
                        ExperienceLevel = (Api.Models.Common.V1.ExperienceLevel)job.RequiredExperience.ExperienceLevel
                    },

                    PreferredQualifications = job.PreferredQualifications,
                    JobResponsibilities = job.JobResponsibilities,
                    Benefits = job.Benefits,
                    WorkEnvironment = job.WorkEnvironment,
                    Tags = job.Tags,
                    PostingDate = job.PostingDate,
                    ApplicationDeadline = job.PostingDate
                };
                #endregion
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