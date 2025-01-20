using System.Data.Common;
using JobLeet.WebApi.JobLeet.Api.Caching;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1
{
    public class RoleRepository : IRoleRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;
        private readonly BaseCacheHelper<List<RoleModel>> _cacheHelper;

        public RoleRepository(BaseDBContext dbContext, IMemoryCache memoryCache)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _cacheHelper = new BaseCacheHelper<List<RoleModel>>(memoryCache);
        }
        #endregion
        public Task<RoleModel> AddAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        #region Retrieve Roles Asynchronously
        /// <returns>The list of Roles.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all Roles from the database using Entity Framework Core.</remarks>
        public async Task<List<RoleModel>> GetAllAsync()
        {
            var cacheKey = CacheHelper.CacheKey("RandomKey");
            MemoryCacheEntryOptions cacheOptions = CacheHelper.GetCacheOptions(
                TimeSpan.FromMinutes(1)
            );
            return await _cacheHelper.GetCachedResponse(
                cacheKey,
                async () =>
                {
                    try
                    {
                        var results = await _dbContext
                            .Roles.Select(e => new RoleModel
                            {
                                Id = e.Id,
                                RoleName = (Api.Models.Accounts.V1.RoleCategory)e.RoleName,
                            })
                            .ToListAsync();
                        return results;
                    }
                    catch (Exception ex) when (ex is DbUpdateException || ex is DbException)
                    {
                        throw new Exception(
                            "Error while fetching data from the database. Please try again later."
                        );
                    }
                },
                cacheOptions
            );
        }
        #endregion
        public Task<RoleModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
