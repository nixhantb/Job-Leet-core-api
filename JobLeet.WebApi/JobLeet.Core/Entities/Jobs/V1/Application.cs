using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Application : BaseEntity
    {
        [ForeignKey("Employer")]
        public Employer Employer { get; set; }

        [ForeignKey("Job")]
        public Job Job { get; set; }

        [ForeignKey("Status")]
        public Status Status { get; set; }

    }
}
