using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using JobLeet.WebApi.JobLeet.Api.Exceptions;
using FluentValidation;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Authorize]
    [Route("api/v1/seekers")]
    public class SeekersController : BaseApiController<Seeker, SeekerModel, ISeekerRepository>
    {
        public SeekersController(ISeekerRepository seekerRepository, ILoggerManagerV1 logger, IValidator<Seeker> validator)
            : base(seekerRepository, logger, validator)
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
