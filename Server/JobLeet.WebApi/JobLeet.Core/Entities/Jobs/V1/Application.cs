using System.ComponentModel.DataAnnotations.Schema;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Application : BaseEntity
    {
        public int SeekerId { get; set; }
        public Seeker? Seekers { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public int JobId { get; set; }

        [ForeignKey(nameof(JobId))]
        public JobEntity? Jobs { get; set; }
        public ApplicationDate? ApplicationDate { get; set; }
        public Status? Status { get; set; }
    }
}
