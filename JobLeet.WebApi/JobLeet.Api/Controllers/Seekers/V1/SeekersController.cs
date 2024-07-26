using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using JobLeet.WebApi.JobLeet.Api.Exceptions;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Authorize]
    [Route("api/v1/seekers")]
    public class SeekersController : BaseApiController<Seeker, SeekerModel, ISeekerRepository>
    {
        public SeekersController(ISeekerRepository seekerRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService)
            : base(seekerRepository, logger, rabbitMQService)
        {
            
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] Seeker entity)
        {
            try
            {
                if (entity == null)
                {
                    return BadRequest();
                }

                var result = await Repository.AddAsync(entity);
                try
                {
                    string topic = "Jobleetseekers";
                    _rabbitMQService.PublishMessage(topic,$"New seeker created: {entity}");
                }
                catch (Exception rabbitMqEx)
                {
                    _logger.LogError($"RabbitMQ error: {rabbitMqEx.Message}");
                    return StatusCode(500, new GlobalErrorResponse
                    {
                        Error = "RabbitMQ Error",
                        Message = "An error occurred while publishing the message to RabbitMQ."
                    });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while creating the entity: {ex.Message}");
                var errorResponse = new GlobalErrorResponse
                {
                    Error = "System Exception",
                    Message = ex.Message
                };
                return StatusCode(400, errorResponse);
            }
        }

    }
}
