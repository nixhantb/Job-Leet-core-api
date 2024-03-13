namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class MetaDataModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
    }
}
