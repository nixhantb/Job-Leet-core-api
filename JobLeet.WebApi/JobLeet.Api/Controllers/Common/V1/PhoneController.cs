using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/jobleet-phones")]
    public class PhoneController : BaseApiController<PhoneModel, IPhoneRepository>
    {
        public PhoneController(IPhoneRepository phoneRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService) : base(phoneRepository, logger, rabbitMQService)
        { 

        }

    }
}
