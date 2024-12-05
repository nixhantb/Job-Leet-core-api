using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1
{
    public class ApplicationModel : BaseModel
    {
        public SeekerModel Seekers{get; set;}
        public EmployerModel Employer {get; set;}
        public JobModel Jobs {get; set;}
        public ApplicationDateModel ApplicationDate { get; set; }
        public StatusModel Status { get; set; }
        
    }
}
