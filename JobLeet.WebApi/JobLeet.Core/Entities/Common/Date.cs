namespace JobLeet.WebApi.JobLeet.Core.Entities.Common
{
    public class Date : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt {  get; set; }
    }
}
