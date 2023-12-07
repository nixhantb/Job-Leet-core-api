using System.ComponentModel.DataAnnotations;
namespace JobLeet.WebApi.JobLeet.Api.Models.Companies.V1
{
    public class CompanyModel : BaseModel
    {
        [Required(ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Company profile is required")]
        public CompanyProfileModel Profile { get; set; }
    }
}
