namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Qualification : BaseEntity
    {
        public List<QualificationType> QualificationTypes { get; set; }
        public string QualificationInformation { get; set; }
    }

    public enum QualificationType
    {
        Education,
        Skill,
        Certification
    }
}
