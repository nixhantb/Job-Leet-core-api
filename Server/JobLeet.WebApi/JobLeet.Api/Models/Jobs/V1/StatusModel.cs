namespace JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1
{
    public class StatusModel : BaseModel
    {
        public StatusName StatusName { get; set; }
    }
    public enum StatusName
    {
        Active,
        Inactive,
        Pending,
        Completed,
        Cancelled
    }
}
