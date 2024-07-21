using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Route("api/v1/seekers")]
    public class SeekersController: BaseApiController<Seeker,SeekerModel, ISeekerRepository>
    {
        public SeekersController(ISeekerRepository seekerRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService) : base(seekerRepository, logger, rabbitMQService)
        { 

        }
    }
}
