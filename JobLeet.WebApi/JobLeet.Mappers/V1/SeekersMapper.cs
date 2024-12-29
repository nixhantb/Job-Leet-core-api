
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
                Id = entity.Id,
                Phone = PhoneMapper.ToPhoneDatabase(entity.Phone),
                Address = AddressMapper.ToAddressDatabase(entity.Address),
                Skills = SkillsMapper.ToSkillsDB(entity.Skills),
                Education = EducationMapper.ToEducationDatabase(entity.Education),
                Experience = new()
                {
                    ExperienceLevel = entity.Experience.ExperienceLevel
                },
                DateOfBirth = entity.DateOfBirth,
                Qualifications = new()
                {
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
                Id = model.Id,
                Phone = model.Phone != null ? PhoneMapper.ToPhoneModel(model.Phone) : null,
                Address = model.Address != null ? AddressMapper.ToAddressModel(model.Address) : null,
                Skills = model.Skills != null ? SkillsMapper.ToSkillModel(model.Skills) : null,
                Education = model.Education != null ? EducationMapper.ToEducationModel(model.Education) : null,
                
                Experience = model.Experience != null
                ? new Api.Models.Common.V1.ExperienceModel
                {
                    ExperienceLevel = model.Experience.ExperienceLevel != null
                        ? (Api.Models.Common.V1.ExperienceLevel)model.Experience.ExperienceLevel
                        : default(Api.Models.Common.V1.ExperienceLevel)
                }
                : null,
                DateOfBirth = model.DateOfBirth,
                Qualifications = model.Qualifications != null
                ? new Api.Models.Common.V1.QualificationModel
                {
                    QualificationType = model.Qualifications.QualificationType != null
                        ? (Api.Models.Common.V1.QualificationCategory)model.Qualifications.QualificationType
                        : default(Api.Models.Common.V1.QualificationCategory),
                    QualificationInformation = model.Qualifications.QualificationInformation
                }
                : null,
                ProfileSummary = model.ProfileSummary,
                LinkedInProfile = model.LinkedInProfile,
                Portfolio = model.Portfolio,
                Interests = model.Interests,
                Achievements = model.Achievements
            };
        }

    }
}