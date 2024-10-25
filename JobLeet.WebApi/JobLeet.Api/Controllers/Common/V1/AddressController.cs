using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/addresses")]
    public class AddressController : BaseApiController<Address,AddressModel, IAddressRepository>
    {
        public AddressController(IAddressRepository addressRepository, ILoggerManagerV1 logger) : base(addressRepository, logger)
        { 

        }
    }
}
