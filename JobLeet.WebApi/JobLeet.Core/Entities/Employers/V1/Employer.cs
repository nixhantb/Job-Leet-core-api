using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1
{
    public class Employer : BaseEntity
    {
        public PersonName? Name { get; set; }
        public Address? Address { get; set; }
        public Phone? Phone { get; set; }
        public CompanyProfile? Profile { get; set; }
        public EmployerType? EmployerType { get; set; }
        public IndustryType? IndustryType { get; set; }

    }   
}
