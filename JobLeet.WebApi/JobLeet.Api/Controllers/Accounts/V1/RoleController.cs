using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Accounts.V1
{
    [Route("api/v1/roles")]
    public class RoleController : BaseApiController<RoleModel, IRoleRepository>
    {
        public RoleController(IRoleRepository roleRepository, ILoggerManagerV1 loggerManagerV1)
            : base(roleRepository, loggerManagerV1) 
        {
        
        }
    }
}
