using System.Data.Common;
using System.Security.Claims;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1.Identity;
using JobLeet.WebApi.JobLeet.Mappers.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1
{
    public class SeekersRepository : ISeekerRepository
    {
        #region Initialization
        private readonly BaseDBContext _dbContext;
        private readonly ApplicationDbContext _authContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        #endregion

        public SeekersRepository(
            BaseDBContext dbContext,
            ApplicationDbContext authContext,
            IHttpContextAccessor httpContextAccessor
        )
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _authContext = authContext ?? throw new ArgumentNullException(nameof(authContext));
            _httpContextAccessor =
                httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<SeekerModel> AddAsync(Seeker entity)
        {
            try
            {
                // Get the logged-in user's ID from the claims
                var userId = _httpContextAccessor
                    .HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)
                    ?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("Unable to retrieve the logged-in user ID.");
                }

                // Check if the user exists in the AspNetUsers table
                var user = await _authContext.Users.FirstOrDefaultAsync(e => e.Id == userId);
                if (user == null)
                {
                    throw new Exception("User not found in the identity database.");
                }

                // Map the Seeker entity to the database model, using the logged-in user's ID
                var seekersEntity = SeekersMapper.ToSeekerDataBase(entity, userId);

                // Add and save the Seekers entity to the database
                await _dbContext.AddAsync(seekersEntity);
                await _dbContext.SaveChangesAsync();

                // Map the database entity back to the response model
                var seekersResponse = SeekersMapper.ToSeekerModel(seekersEntity);
                return seekersResponse;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while adding seeker: {ex.Message}");
            }
        }

        public async Task<SeekerModel> GetByIdAsync(string id)
        {
            try
            {
                var seeker = await _dbContext
                    .Seekers.Where(c => c.Id.Equals(id))
                    .Include(c => c.Phone)
                    .Include(c => c.Address)
                    .Include(c => c.Skills)
                    .Include(c => c.Education)
                    .Include(c => c.Qualifications)
                    .Include(c => c.Experience)
                    .ThenInclude(e => e.Company)
                    .ThenInclude(c => c.Profile)
                    .ThenInclude(p => p.ContactEmail)
                    .Include(e => e.Experience)
                    .ThenInclude(c => c.Company)
                    .ThenInclude(p => p.Profile)
                    .ThenInclude(a => a.CompanyAddress)
                    .Include(e => e.Experience)
                    .ThenInclude(c => c.Company)
                    .ThenInclude(p => p.Profile)
                    .ThenInclude(p => p.ContactPhone)
                    .Include(e => e.Experience)
                    .ThenInclude(c => c.Company)
                    .ThenInclude(p => p.Profile)
                    .ThenInclude(it => it.IndustryTypes)
                    .FirstOrDefaultAsync();

                var seekerModel = SeekersMapper.ToSeekerModel(seeker);
                return seekerModel;
            }
            catch (Exception ex) when (ex is DbUpdateException || ex is DbException)
            {
                throw new Exception(
                    "The Seekers with the requested ID doesn't exist or a database exception occurred.",
                    ex
                );
            }
        }

        public async Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SeekerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Seeker entity)
        {
            throw new NotImplementedException();
        }
    }
}
