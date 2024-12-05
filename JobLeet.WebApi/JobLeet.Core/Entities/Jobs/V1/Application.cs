
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Application : BaseEntity
    {
        public Seeker Seekers {get; set;}
        public Employer Employer {get; set;}
        public JobEntity Jobs {get; set;}
        public ApplicationDate ApplicationDate { get; set; }
        public Status Status { get; set; }

    }
}
