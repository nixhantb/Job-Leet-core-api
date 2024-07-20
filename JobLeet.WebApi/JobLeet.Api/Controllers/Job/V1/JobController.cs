using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Route("api/v1/jobs")]
    public class JobController: BaseApiController<JobEntity,JobModel, IJobRepository>
    {
        public JobController(IJobRepository jobRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService) : base(jobRepository, logger, rabbitMQService)
        { 

        }
    }
}
