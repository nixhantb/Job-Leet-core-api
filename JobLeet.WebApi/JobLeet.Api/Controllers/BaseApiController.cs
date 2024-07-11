using JobLeet.WebApi.JobLeet.Api.Exceptions;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Core.Interfaces;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers
{
   
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class BaseApiController<T, TRepository> : ControllerBase where T : class where TRepository : IRepository<T>
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        protected readonly TRepository Repository;
        private readonly ILoggerManagerV1 _logger;
        private readonly RabbitMQService _rabbitMQService;

        protected BaseApiController(TRepository repository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService)
        {
            Repository = repository;
            _logger = logger;
            _rabbitMQService = rabbitMQService;
        }
        #endregion

        #region Retrieve record GET request
        /// <returns>The list of records.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all the records from the database using Entity Framework Core.</remarks>
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
        #endregion

        #region Retrieve record GET By ID request
        /// <returns>The list of records By ID.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all the records by ID from the database using Entity Framework Core.</remarks>
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
        #endregion

        #region POST Request
        /// <returns>The newly created POST Request</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method posts the records to the database using Entity Framework Core.</remarks>
        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync([FromBody] T entity)
        {
           try
            {
                if(entity == null)
                {
                    return BadRequest();
                }
                var result = await Repository.AddAsync(entity);
                _rabbitMQService.PublishMessage($"New entity created: {entity}");
                return Ok(result);


            }
            catch(Exception ex)
            {
                _logger.LogError($"Error occured while creating the entity: {ex.Message}");
                var errorResponse = new GlobalErrorResponse
                {
                    Error = "System Exception ",
                    Message = ex.Message
                };
                return StatusCode(400, errorResponse);
            }
        }
        #endregion
    }


}
