using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Profiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        [ForeignKey("CompanyProfile")]
        public CompanyProfile Profile { get; set; }
    }
}
