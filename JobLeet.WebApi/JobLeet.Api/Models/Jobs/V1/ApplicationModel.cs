using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1
{
    public class ApplicationModel : BaseModel
    {
        public EmployerModel Employer { get; set; }
        public JobModel Job { get; set; }
        public StatusModel Status { get; set; }
    }
}
