namespace JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.IndustryTypes
{
    public class IndustryType : BaseEntity
    {
        public IndustryCategory IndustryCategory {  get; set; }
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
