namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Email : BaseEntity
    {
        public EmailType EmailType { get; set; }
        public string EmailAddress { get; set; }
    }
    public enum EmailType
    {
        Personal,
        Work,
        Other
    }
}
