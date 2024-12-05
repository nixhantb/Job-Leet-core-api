using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Route("api/v1/applications")]
    public class ApplicationController: BaseApiController<Application,ApplicationModel, IApplicationRepository>
    {
        public ApplicationController(IApplicationRepository applicationRepository, ILoggerManagerV1 logger) : base(applicationRepository, logger)
        { 

        }
    }
}
