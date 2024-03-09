using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class EmailTypeRepository : IEmaiTypeRepository 
    {
        private readonly BaseDBContext _dbContext;
        
        public EmailTypeRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<EmailModel> GetByIdAsync(int id)
        {
            throw new NotSupportedException();
        }

        public async Task<List<EmailModel>> GetAllAsync()
        {
            try
            {
                var result = await _dbContext.Emails
                    .Select(e => new EmailModel
                    {
                        Id = e.Id,
                        EmailType = (EmailCategory)e.EmailType,
                    }).ToListAsync();

                return result;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error while fetching the database. Please try again later."+ex.Message);
            }
        }

        public Task AddAsync(EmailModel emailType)
        {
            throw new NotSupportedException();
        }

        public Task UpdateAsync(EmailModel emailType)
        {
            throw new NotSupportedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotSupportedException();
        }
    }
}
