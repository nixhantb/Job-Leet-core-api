namespace JobLeet.WebApi.JobLeet.Api.Models.Companies.V1
{
    public class IndustryTypeModel : BaseModel
    {
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
