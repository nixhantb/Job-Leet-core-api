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
            try
            {
                var email = await _dbContext.Emails
                    .Where(e => e.Id == id)
                    .Select(e => new EmailModel
                    {
                        Id = e.Id,
                        EmailType = (EmailCategory)e.EmailType
                    })
                    .FirstOrDefaultAsync();

                if (email == null)
                    throw new KeyNotFoundException($"Email with id {id} not found");

                return email;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while fetching email with id {id}: {ex.Message}");
            }
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
