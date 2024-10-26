using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/register")]
    public class RegisterUserController : BaseApiController<RegisterUser,RegisterUserModel, IRegisterUserRepository>
    {
        public RegisterUserController(IRegisterUserRepository registerUserRepository, ILoggerManagerV1 logger)
            : base(registerUserRepository, logger)
        {
            
        }
    }
}
