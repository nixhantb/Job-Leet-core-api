using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Job : BaseEntity
    {
        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address JobAddress { get; set; }
        [ForeignKey("Qualification")]
        public int QualificationId { get; set; }
        public Qualification RequiredQualification { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int Vacancies { get; set; }
        [ForeignKey("Experience")]
        public int ExperienceId { get; set; }
        public Experience RequiredExperience { get; set; }

        public decimal BasicPay { get; set; }
        public string FunctionalArea { get; set; }
        [ForeignKey("IndustryType")]
        public int IndustryTypeId { get; set; }
        public IndustryType IndustryType { get; set; }

        public DateTime PostingDate { get; set; }
    }
}
