using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Job.V1
{
    [Authorize]
    [Route("api/v1/seekers")]
    public class SeekersController : BaseApiController<Seeker, SeekerModel, ISeekerService>
    {
        public SeekersController(ISeekerService seekerService, ILoggerManagerV1 logger, IValidator<Seeker> validator)
            : base(seekerService, logger, validator)
        {
        }
    }
}
