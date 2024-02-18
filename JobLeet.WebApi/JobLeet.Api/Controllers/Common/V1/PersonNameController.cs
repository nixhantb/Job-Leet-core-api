using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    public class PersonNameController: BaseApiController<PersonNameModel, IPersonNameRepository>
    {
        public PersonNameController(IPersonNameRepository personNameRepository, ILoggerManagerV1 logger)
            : base(personNameRepository, logger)
        {

        }
    }
}
