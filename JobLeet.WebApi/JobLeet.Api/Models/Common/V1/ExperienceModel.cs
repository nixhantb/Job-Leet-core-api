namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class ExperienceModel : BaseModel
    {
        public ExperienceLevel ExperienceLevel { get; set; }
    }
    public enum ExperienceLevel
    {
        EntryLevel,
        Intermediate,
        Senior,
        Lead,
        Principal,
        Executive,
        Others
    }
}
