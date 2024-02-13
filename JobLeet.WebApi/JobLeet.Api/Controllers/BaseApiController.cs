using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers
{
    [ApiController]
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
            _logger.LogInfo("Triggering HTTP GET request");
            var entities = await Repository.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync([FromBody] T entity)
        {
            await Repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = 1 }, entity); 
        }
    }

   
}
