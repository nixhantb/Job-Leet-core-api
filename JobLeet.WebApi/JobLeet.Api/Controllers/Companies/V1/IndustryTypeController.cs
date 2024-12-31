using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Companies.V1;
using Microsoft.AspNetCore.Mvc;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Companies.v1{

[Route("api/v1/industry-types")]
    public class IndustryTypeController: BaseApiController<Industry,IndustryModel, IIndustryTypeRepository>
    {
        public IndustryTypeController(IIndustryTypeRepository industryTypeRepository, ILoggerManagerV1 logger) : base(industryTypeRepository, logger)
        { 

        }
    }

}