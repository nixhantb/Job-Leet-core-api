namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class MetaData
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
       
    }
}
