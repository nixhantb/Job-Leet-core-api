using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{
    public static class ApplicationMapper
    {
        public static Application ToApplicationDataBase(Application entity, string userId)
        {
            if (entity == null)
            {
                return null;
            }

            return new Application
            {
                Seekers = SeekersMapper.ToSeekerDataBase(entity.Seekers, userId),
                Company = CompanyMapper.ToCompanyDataBase(entity.Company),
                Jobs = JobsMapper.ToJobDatabase(entity.Jobs),
                ApplicationDate = new()
                {
                    SubmitDate = entity.ApplicationDate.SubmitDate,
                    ReviewDate = entity.ApplicationDate.ReviewDate,
                    DecisionDate = entity.ApplicationDate.DecisionDate,
                    Comments = entity.ApplicationDate.Comments,
                },
                Status = new() { StatusName = entity.Status.StatusName },
            };
        }

        // API Response
        public static ApplicationModel ToApplicationModel(Application model)
        {
            if (model == null)
            {
                return null;
            }

            return new ApplicationModel
            {
                Seekers = SeekersMapper.ToSeekerModel(model.Seekers),
                Company = CompanyMapper.ToCompanyModel(model.Company),
                Jobs = JobsMapper.ToJobModel(model.Jobs),

                ApplicationDate = new()
                {
                    SubmitDate = model.ApplicationDate.SubmitDate,
                    ReviewDate = model.ApplicationDate.ReviewDate,
                    DecisionDate = model.ApplicationDate.DecisionDate,
                    Comments = model.ApplicationDate.Comments,
                },
                Status = new()
                {
                    StatusName = (Api.Models.Jobs.V1.StatusName)model.Status.StatusName,
                },
            };
        }
    }
}
