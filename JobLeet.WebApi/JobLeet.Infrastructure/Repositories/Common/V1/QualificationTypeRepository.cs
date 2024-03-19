using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class QualificationTypeRepository : IQualificationTypeRepository
    {
        private readonly BaseDBContext _dbContext;
        public QualificationTypeRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(QualificationModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<QualificationModel>> GetAllAsync()
        {
            try
            {
                var result = await _dbContext.Qualifications
                   .Select(e => new QualificationModel
                   {
                       Id = e.Id,
                       QualificationType = (QualificationCategory)e.QualificationType,
                       QualificationInformation = e.QualificationInformation
                   })
                   .ToListAsync();

                return result;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error while fetching the database. Please try again later" + ex.Message);
            }
        }

        public Task<QualificationModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(QualificationModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
