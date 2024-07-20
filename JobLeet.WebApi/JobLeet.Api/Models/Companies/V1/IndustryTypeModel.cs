using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Api.Models.Companies.V1
{
    public class IndustryTypeModel : BaseModel
    {
        [EnumDataType(typeof(IndustryCategory), ErrorMessage = "Invalid industry category")]
        public IndustryCategory IndustryCategory { get; set; }
    }
    public enum IndustryCategory
    {
        Technology,
        Healthcare,
        Finance,
        Manufacturing,
        Others
    }
}
