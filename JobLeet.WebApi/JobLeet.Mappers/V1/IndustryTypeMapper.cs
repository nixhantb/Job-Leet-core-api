using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1 {

    public static class IndustryTypeMapper{
        
        public static IndustryType ToIndustryTypeDB (IndustryType entity){
            return new IndustryType {
                IndustryCategory = entity.IndustryCategory
            };
        }
        public static IndustryTypeModel ToIndustryTypeMapper (IndustryType model){
            return new IndustryTypeModel{
                IndustryCategory = (Api.Models.Companies.V1.IndustryCategory)model.IndustryCategory
            };
        }
    }
}