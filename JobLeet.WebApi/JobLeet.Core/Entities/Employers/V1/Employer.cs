using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1
{
    public class Employer : BaseEntity
    {
        [ForeignKey("User")]
        public User User { get; set; }
        [ForeignKey("Name")]
        public PersonName Name { get; set; }
        [ForeignKey("Address")]
        public Address Address { get; set; }

        [ForeignKey("Phone")]
        public Phone Phone { get; set; }

        [ForeignKey("Profile")]
        public CompanyProfile Profile { get; set; }
        public EmployerType EmployerType { get; set; }
        [ForeignKey("IndustryType")]
        public IndustryType IndustryType { get; set; }

    }   
}
