using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class Job : BaseEntity
    {
        [ForeignKey("Employer")]
        public Employer Employer { get; set; }
        [ForeignKey("Address")]
        public Address JobAddress { get; set; }
        [ForeignKey("Qualification")]
        public Qualification RequiredQualification { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int Vacancies { get; set; }
        [ForeignKey("Experience")]
        public Experience RequiredExperience { get; set; }
        public decimal BasicPay { get; set; }
        public string FunctionalArea { get; set; }
        [ForeignKey("IndustryType")]
        public IndustryType IndustryType { get; set; }

        public DateTime PostingDate { get; set; }
    }
}
