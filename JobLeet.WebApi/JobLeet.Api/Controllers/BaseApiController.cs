using JobLeet.WebApi.JobLeet.Api.Exceptions;
using JobLeet.WebApi.JobLeet.Api.Exceptions.CustomExceptionWrappers.V1;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public abstract class BaseApiController<T, TRepository> : ControllerBase where T : class where TRepository : IRepository<T>
    {
        protected readonly TRepository Repository;
        private readonly ILoggerManagerV1 _logger;

        protected BaseApiController(TRepository repository, ILoggerManagerV1 logger)
        {
            Repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            try
            {
                _logger.LogInfo("Triggering HTTP GET request");
                var entities = await Repository.GetAllAsync();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching all entities: {ex.Message}");
                var errorResponse = new GlobalErrorResponse
                {
                    Error = "Internal Server Error",
                    Message = ex.Message
                };
                return StatusCode(500, errorResponse);
            }
           
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
           try
            {
                var entity = await Repository.GetByIdAsync(id);

                if (entity == null)
                    return NotFound();

                return Ok(entity);
            }

            catch(Exception ex)
            {
                _logger.LogError($"An error occurred while fetching the data: {ex.Message}");
                var errorResponse = new GlobalErrorResponse
                {
                    Error = "System Exception ",
                    Message = ex.Message
                };
                return StatusCode(400, errorResponse);
            }
           
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync([FromBody] T entity)
        {
            await Repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = 1 }, entity); 
        }
    }

   
}
