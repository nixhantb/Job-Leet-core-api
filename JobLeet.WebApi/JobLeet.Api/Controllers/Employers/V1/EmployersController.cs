using JobLeet.WebApi.JobLeet.Api.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using JobLeet.WebApi.JobLeet.Api.Exceptions;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using FluentValidation;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Authorize]
    [Route("api/v1/employers")]
    public class EmployerController : BaseApiController<Employer, EmployerModel, IEmployerRepository>
    {
        public EmployerController(IEmployerRepository employerRepository, ILoggerManagerV1 logger, IValidator<Employer> validator)
            : base(employerRepository, logger, validator)
        {
            
        }
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] Employer entity)
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
