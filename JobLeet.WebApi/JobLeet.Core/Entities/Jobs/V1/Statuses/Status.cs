namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.Statuses
{
    public class Status : BaseEntity
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
