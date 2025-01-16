using FluentValidation;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/logins")]
    [ApiController]
    public class LoginUserController : BaseApiController<LoginUser, LoginUserModel, ILoginUserRepository>
    {
        public LoginUserController(ILoginUserRepository loginUserRepository, ILoggerManagerV1 logger, IValidator<LoginUser> validator)
            : base(loginUserRepository, logger, validator) { }
    }
}
