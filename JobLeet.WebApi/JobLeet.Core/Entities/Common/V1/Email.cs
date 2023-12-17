namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Email : BaseEntity
    {
        public EmailCategory EmailType { get; set; }
        public string? EmailAddress { get; set; }
    }
    
}
