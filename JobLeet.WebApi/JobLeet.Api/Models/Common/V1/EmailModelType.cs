namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class EmailModelType
    {
        public EmailCategory EmailCategory { get; set; }
    }
    public enum EmailCategory
    {
        Personal,
        Work,
        Other
    }
}
