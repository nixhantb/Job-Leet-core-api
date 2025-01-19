using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;

namespace JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1
{
    public interface IApplicationRepository : IRepository<Application, ApplicationModel>
    {
        Task<Application> ApplyForJobAsync(int seekerId, int jobId, int companyId);
        Task<Application> UpdateApplicationStatusAsync(int applicationId, Status status);
    }
}
