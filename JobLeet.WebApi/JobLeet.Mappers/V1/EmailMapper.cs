using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1 {

    public static class EmailMapper{
        
        public static Email ToEmailDatabase (Email entity){
            return new Email {
                Id = entity.Id,
                EmailAddress = entity.EmailAddress,
                EmailType = entity.EmailType,
            };
        }
        public static EmailModel ToEmailModel (Email model){
            return new EmailModel {};
        }
    }
}