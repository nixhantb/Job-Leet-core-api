using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using System.ComponentModel.DataAnnotations;
namespace JobLeet.WebApi.JobLeet.Api.Models.Employers.V1
{
    public class EmployerModel : BaseModel
    {
        [Required(ErrorMessage = "Employer name is required")]
        public PersonNameModel Name { get; set; }
        [Required(ErrorMessage = "Employer address is required")]
        public AddressModel Address { get; set; }
        [Required(ErrorMessage = "Employer Phone is required")]
        public PhoneModel Phone { get; set; }
        [Required(ErrorMessage = "Company Profile model is required")]
        public CompanyProfileModel Profile { get; set; }
       // [Required(ErrorMessage = "Employer Type is required")]
        public EmployerTypeModel EmployerType { get; set; }
        [Required(ErrorMessage = "Industry Type is required")]
        public IndustryTypeModel IndustryType { get; set; }
    }
    public enum EmployerTypeModel
    {
        SmallBusiness,
        MediumBusiness,
        LargeCorporation
    }
}
