namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Experience : BaseEntity
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
