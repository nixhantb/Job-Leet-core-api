using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/logins")]
    public class LoginUserController : BaseApiController<LoginUserModel, ILoginUserRepository>
    {
        public LoginUserController(ILoginUserRepository loginUserRepository, ILoggerManagerV1 logger)
            : base(loginUserRepository, logger) { }
    }
}
