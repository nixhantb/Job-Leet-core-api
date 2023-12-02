namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class EmailModel : BaseModel
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
