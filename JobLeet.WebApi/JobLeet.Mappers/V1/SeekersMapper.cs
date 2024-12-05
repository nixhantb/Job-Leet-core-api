
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{

    public static class SeekersMapper
    {

        public static Seeker ToSeekerDataBase(Seeker entity)
        {

            if (entity == null)
            {
                return null;
            }
           
            return new Seeker
            {
                Phone = PhoneMapper.ToPhoneDatabase(entity.Phone),
                Address = AddressMapper.ToAddressDatabase(entity.Address),
                Skills =  SkillsMapper.ToSkillsDB(entity.Skills),
                Education = EducationMapper.ToEducationDatabase(entity.Education),
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
        }



        // API Response
        public static SeekerModel ToSeekerModel(Seeker model)
        {
            if (model == null)
            {
                return null;
            }

            
            return new SeekerModel
            {
                Phone = PhoneMapper.ToPhoneModel(model.Phone),
                Address = AddressMapper.ToAddressModel(model.Address),
                Skills = SkillsMapper.ToSkillModel(model.Skills),
                Education = EducationMapper.ToEducationModel(model.Education),
                Experience = new(){
                    ExperienceLevel = (Api.Models.Common.V1.ExperienceLevel)model.Experience.ExperienceLevel
                },
                DateOfBirth = model.DateOfBirth,
                Qualifications = new(){
                    QualificationType = (Api.Models.Common.V1.QualificationCategory)model.Qualifications.QualificationType,
                    QualificateionInformation = model.Qualifications.QualificationInformation

                },
                ProfileSummary = model.ProfileSummary,
                LinkedInProfile = model.LinkedInProfile,
                Portfolio = model.Portfolio,
                Interests = model.Interests,
                Achievements = model.Achievements
            };
        }

    }
}