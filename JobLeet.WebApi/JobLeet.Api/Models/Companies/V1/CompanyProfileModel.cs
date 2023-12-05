
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Api.Models.Companies.V1
{
    public class CompanyProfileModel : BaseModel
    {
        [Required(ErrorMessage = "Profile Info is required")]
        [StringLength(1000)]
        public string ProfileInfo { get; set; }
        [Required(ErrorMessage = "Company address is required")]
        public AddressModel CompanyAddress { get; set; }
        [Required(ErrorMessage = "Phone detail is required")]
        public PhoneModel ContactPhone { get; set; }
        [Required(ErrorMessage = "Email detail is required")]
        public EmailModel ContactEmail { get; set; }
        /// <summary>
        /// Website can be extended in future based on the requirements
        /// </summary>
        [Required(ErrorMessage = "Website information is required")]
        public string Website { get; set; }
        [Required(ErrorMessage = "Industry type is required")]
        public IndustryTypeModel IndustryType { get; set; }
    }
}
