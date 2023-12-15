namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class EmailType
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
