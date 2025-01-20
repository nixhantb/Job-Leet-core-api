using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;

namespace JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1
{
    public interface IRegisterUserRepository : IRepository<RegisterUser, RegisterUserModel> { }
}
