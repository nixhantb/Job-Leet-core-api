namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class QualificationModel : BaseModel
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
