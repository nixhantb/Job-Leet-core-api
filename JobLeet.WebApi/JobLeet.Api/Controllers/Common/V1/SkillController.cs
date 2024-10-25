using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.AspNetCore.Mvc;
namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/leet-skills")]
    public class SkillController : BaseApiController<Skill,SkillModel, ISkillRepository>
    {
        public SkillController(ISkillRepository skillRepository, ILoggerManagerV1 logger):
        
            base(skillRepository, logger)
        {
        
        }
    }
}
