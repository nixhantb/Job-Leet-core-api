using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class ExperienceRepository : IExperienceRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;
        public ExperienceRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
        public Task AddAsync(ExperienceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {

            throw new NotImplementedException();
        }

        #region Retrieve Experience Asynchronously
        /// <returns>The list of experiences.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all experiences from the database using Entity Framework Core.</remarks>
        public Task<List<ExperienceModel>> GetAllAsync()
        {
            try
            {
                var results = _dbContext.Experiences
                    .Select(e => new ExperienceModel
                    {
                        Id = e.Id,
                        ExperienceLevel = (ExperienceLevel)e.ExperienceLevel
                    }).ToListAsync();
                return results;
            }
            catch(DbUpdateException ex)
            {
                throw new Exception("Error while fetching the database. Please try again later " + ex.Message);
            }
        }
        #endregion

        #region Retrieve Experience ID Asynchronously
        /// <returns>The list of experience Id's.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all experience Id's from the database using Entity Framework Core.</remarks>
        public Task<ExperienceModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        public Task UpdateAsync(ExperienceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
