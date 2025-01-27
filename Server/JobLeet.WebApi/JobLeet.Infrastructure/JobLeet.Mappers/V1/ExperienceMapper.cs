using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{
    public static class ExperienceMapper
    {
        public static Experience ToExperienceDatabase(Experience entity)
        {
            return new Experience
            {
                Id = entity.Id,
                Company = CompanyMapper.ToCompanyDataBase(entity.Company),
                ExperienceLevel = entity.ExperienceLevel,
                ExperienceDateFrom = entity.ExperienceDateFrom,
            };
        }

        public static ExperienceModel ToExperienceModel(Experience model)
        {
            return new ExperienceModel
            {
                Id = model.Id,
                CompanyModel = CompanyMapper.ToCompanyModel(model.Company),
                ExperienceLevel = (Api.Models.Common.V1.ExperienceLevel)model.ExperienceLevel,
                ExperienceDateTill = model.ExperienceDateTill,
            };
        }
    }
}
