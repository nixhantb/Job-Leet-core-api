using FluentValidation;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Route("api/v1/applications")]
    [ApiController]
    public class ApplicationController : BaseApiController<Application, ApplicationModel, IApplicationService>
    {
        public ApplicationController(IApplicationService applicationService, ILoggerManagerV1 logger, IValidator<Application> validator) 
            : base(applicationService, logger, validator)
        {

        }

        [HttpPost("apply")]
        public async Task<IActionResult> ApplyForJobAsync([FromQuery] int seekerId, [FromQuery] int jobId, [FromQuery] int companyId)
        {
            try
            {
                _logger.LogInfo($"Seeker {seekerId} is applying for job {jobId} at company {companyId}.");

                
                var application = await _service.ApplyForJobAsync(seekerId, jobId, companyId); 

                return Ok(application);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while applying for a job: {ex.Message}");
                return StatusCode(500, new
                {
                    Error = "Internal Server Error",
                    Message = ex.Message
                });
            }
        }
    }
}
