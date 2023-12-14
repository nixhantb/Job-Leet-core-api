using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1
{
    public class JobModel : BaseModel
    {
        public AddressModel JobAddress { get; set; }
        public QualificationModel RequiredQualification { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int Vacancies { get; set; }
        public ExperienceModel RequiredExperience { get; set; }

        public decimal BasicPay { get; set; }
        public string FunctionalArea { get; set; }
        public IndustryTypeModel IndustryType { get; set; }

        public DateTime PostingDate { get; set; }
    }
}
