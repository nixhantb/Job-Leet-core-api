using FluentValidation;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/educations")]
    public class EducationController : BaseApiController<Education,EducationModel, IEducationService>
    {
        public EducationController(IEducationService educationService, ILoggerManagerV1 logger, IValidator<Education> validator)
            :base(educationService, logger, validator) { }
        
    }
}
