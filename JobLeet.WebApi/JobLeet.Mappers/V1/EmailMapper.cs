using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1 {

    public static class EmailMapper{
        
        public static EmailModel ToEmailModel (Email entity){
            return new EmailModel {
                Id = entity.Id,
                EmailAddress = entity.EmailAddress,
                EmailType = (Api.Models.Common.V1.EmailCategory)entity.EmailType
            };
        }
    }
}