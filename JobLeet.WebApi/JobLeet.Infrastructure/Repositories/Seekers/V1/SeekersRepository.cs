using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Mappers.V1;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1
{
    public class SeekersRepository : ISeekerRepository
    {
         #region Initialization
        private readonly BaseDBContext _dbContext;

        #endregion

        public SeekersRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<SeekerModel> AddAsync(Seeker entity)
        {
            try {
                
                var seekersEntity = SeekersMapper.ToSeekerDataBase(entity);
                await _dbContext.AddAsync(seekersEntity);
                await _dbContext.SaveChangesAsync();

                var seekersResponse = SeekersMapper.ToSeekerModel(seekersEntity);
                return seekersResponse;
            }
            catch(Exception ex){
                 throw new Exception($"Error occurred while logging in: {ex.Message}");
            }
            
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SeekerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SeekerModel> GetByIdAsync(int id)
        {
            try{

                var seekers = await _dbContext.Seekers.Where(c => c.Id == id)
                .Include(c => c.Phone)
                .Include(c => c.Address)
                .Include(c => c.Skills)
                .Include(c => c.Education)
                .FirstOrDefaultAsync();

                var seekerModel = SeekersMapper.ToSeekerModel(seekers);
                return seekerModel;
            }
             catch (Exception ex)
            {
                throw new Exception("Error Retriving seekers", ex);
            }
        }

        public async Task UpdateAsync(Seeker entity)
        {
            throw new NotImplementedException();
        }
    }
}