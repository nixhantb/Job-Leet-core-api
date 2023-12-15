namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class QualificationModelType
    {
        public QualificationType QualificationType { get; set; }
    }
    public enum QualificationType
    {
        Education,
        Skill,
        Certification
    }
}
