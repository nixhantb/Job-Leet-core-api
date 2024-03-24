using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Application : BaseEntity
    {
        [ForeignKey("ApplicationDate")]
        public ApplicationDate ApplicationDate { get; set; }
        [ForeignKey("Status")]
        public Status Status { get; set; }

    }
}
