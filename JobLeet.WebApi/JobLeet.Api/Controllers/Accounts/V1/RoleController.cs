using FluentValidation;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/roles")]
    public class RoleController : BaseAccountsController<Role,RoleModel, IRoleRepository>
    {
        public RoleController(IRoleRepository roleRepository, ILoggerManagerV1 loggerManagerV1, IValidator<Role> validator)
            : base(roleRepository, loggerManagerV1, validator) 
        {
        
        }
    }
}
