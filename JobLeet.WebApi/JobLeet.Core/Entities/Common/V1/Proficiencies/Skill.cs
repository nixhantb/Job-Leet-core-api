namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualifications
{
   
    /// <summary>
    /// new Skill { Title = "Programming", Description = "Software development skills" },
    /// </summary>

    public class Skill : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
