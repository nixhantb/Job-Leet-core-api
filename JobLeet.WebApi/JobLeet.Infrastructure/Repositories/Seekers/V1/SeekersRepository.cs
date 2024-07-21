using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1
{
    public class SeekersRepository : ISeekerRepository
    {
         #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public SeekersRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<SeekerModel> AddAsync(Seeker entity)
        {
            try {
                
                var seekers = new Seeker{
                    Id = entity.Id,

                    Phone = new(){
                        CountryCode = entity.Phone.CountryCode,
                        PhoneNumber = entity.Phone.PhoneNumber
                    },
                    Address = new(){
                        Street = entity?.Address?.Street,
                        City = entity?.Address?.City,
                        State = entity?.Address?.State,
                        PostalCode = entity?.Address?.PostalCode,
                        Country = entity?.Address?.Country


                    },
                    Skills = new(){
                        Title = entity?.Skills?.Title,
                        Description = entity?.Skills?.Description
                    },
                    Education = new(){
                        Degree = entity.Education.Degree,
                        Major = entity.Education.Major,
                        Institution = entity.Education.Institution,
                        GraduationDate = entity.Education.GraduationDate,
                        Cgpa = entity.Education.Cgpa
                    },

                    Experience = new(){
                        ExperienceLevel = entity.Experience.ExperienceLevel
                    },
                    DateOfBirth = entity.DateOfBirth,
                    Qualifications = new(){
                        QualificationType = entity.Qualifications.QualificationType,
                        QualificationInformation = entity.Qualifications.QualificationInformation
                    },
                    ProfileSummary = entity.ProfileSummary,
                    LinkedInProfile = entity.LinkedInProfile,
                    Portfolio = entity.Portfolio,
                    Interests = entity.Interests,
                    Achievements = entity.Achievements
                };
                _dbContext.Seekers.Add(seekers);
                await _dbContext.SaveChangesAsync();

                var seekersResponse = new SeekerModel{
                    Id = seekers.Id,
                    Phone = new(){
                        Id = seekers.Phone.Id,
                        CountryCode = seekers.Phone.CountryCode,
                        PhoneNumber = seekers.Phone.PhoneNumber
                    },
                    Address = new(){
                        Id = seekers.Address.Id,
                        Street = seekers?.Address?.Street,
                        City = seekers?.Address?.City,
                        State = seekers?.Address?.State,
                        PostalCode = seekers?.Address?.PostalCode,
                        Country = seekers?.Address?.Country
                    },
                    Skills = new(){
                        Id = seekers.Skills.Id,
                        Title = seekers.Skills.Title,
                        Description = seekers.Skills.Description
                    },
                    Education = new(){
                        Id = seekers.Education.Id,
                        Degree = seekers.Education.Degree,
                        Major = seekers.Education.Major,
                        Institution = seekers.Education.Institution,
                        GraduationDate = seekers.Education.GraduationDate,
                        Cgpa = seekers.Education.Cgpa
                    },
                    Experience = new(){
                        Id = seekers.Experience.Id,
                        ExperienceLevel = (Api.Models.Common.V1.ExperienceLevel)seekers.Experience.ExperienceLevel
                    },
                    DateOfBirth = seekers.DateOfBirth,
                    Qualifications = new(){
                        Id = seekers.Qualifications.Id,
                        QualificationType = (Api.Models.Common.V1.QualificationCategory)seekers.Qualifications.QualificationType,
                        QualificateionInformation = seekers.Qualifications.QualificationInformation
                    },
                    ProfileSummary = seekers.ProfileSummary,
                    LinkedInProfile = seekers.LinkedInProfile,
                    Portfolio = seekers.Portfolio,
                    Interests = seekers.Interests,
                    Achievements = seekers.Achievements
                };
                return seekersResponse;
            }
            catch(Exception ex){
                 throw new Exception($"Error occurred while logging in: {ex.Message}");
            }
            
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SeekerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SeekerModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Seeker entity)
        {
            throw new NotImplementedException();
        }
    }
}