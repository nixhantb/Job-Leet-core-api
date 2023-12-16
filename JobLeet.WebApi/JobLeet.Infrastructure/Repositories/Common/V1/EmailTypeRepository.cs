using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class EmailTypeRepository : IEmaiTypeRepository 
    {
        private readonly List<EmailType> _emailTypes;

        public EmailTypeRepository()
        {
            _emailTypes = new List<EmailType>
            {
                new EmailType { Id = 1, EmailCategory = EmailCategory.Work }
            };
        }

        public Task<EmailType> GetByIdAsync(int id)
        {
            return Task.FromResult(_emailTypes.FirstOrDefault(e => e.Id == id));
        }

        public Task<IEnumerable<EmailType>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<EmailType>>(_emailTypes);
        }

        public Task AddAsync(EmailType emailType)
        {
            throw new NotSupportedException();
        }

        public Task UpdateAsync(EmailType emailType)
        {
            throw new NotSupportedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotSupportedException();
        }
    }
}
