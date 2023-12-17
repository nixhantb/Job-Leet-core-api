using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers
{
    [ApiController]
    public abstract class BaseApiController<T, TRepository> : ControllerBase where T : class where TRepository : IRepository<T>
    {
        protected readonly TRepository Repository;

        protected BaseApiController(TRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmailModel>>> GetAllAsync()
        {
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
