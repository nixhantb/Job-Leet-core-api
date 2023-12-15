using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1
{
    public interface IEmailModelType : IRepository<EmailType>
    {
        Task<EmailType> GetByIdAsync(int id);
        Task<IEnumerable<EmailType>> GetAllAsync();
       
    }
}
