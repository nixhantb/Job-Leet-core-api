namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Shared
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
