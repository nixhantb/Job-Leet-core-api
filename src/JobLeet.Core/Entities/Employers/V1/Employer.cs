using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1
{
    public class Employer : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Name")]
        public int NameId { get; set; }
        public PersonName Name { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Phone")]
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public CompanyProfile Profile { get; set; }
        public EmployerType EmployerType { get; set; }
        [ForeignKey("IndustryType")]
        public int IndustryTypeId { get; set; }
        public IndustryType IndustryType { get; set; }

    }
    public enum EmployerType
    {
        SmallBusiness,
        MediumBusiness,
        LargeCorporation
    }
}
