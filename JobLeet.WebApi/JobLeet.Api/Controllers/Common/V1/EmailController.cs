using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.AspNetCore.Mvc;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/email-types")]
    
    public class EmailController : BaseApiController<EmailModel, IEmaiTypeRepository>
    {
        public EmailController(IEmaiTypeRepository emailTypeRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService)
            : base(emailTypeRepository, logger, rabbitMQService)
        {

        }
    }
}
