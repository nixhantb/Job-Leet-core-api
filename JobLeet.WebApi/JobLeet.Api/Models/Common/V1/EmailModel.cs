using System.ComponentModel.DataAnnotations;
namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class EmailModel : BaseModel
    {
        [Required(ErrorMessage = "Email Type is required")]
        public EmailType? EmailType { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address format")]
        public string? EmailAddress { get; set; }
    }
    public enum EmailType
    {
        Personal,
        Work,
        Other
    }
}
