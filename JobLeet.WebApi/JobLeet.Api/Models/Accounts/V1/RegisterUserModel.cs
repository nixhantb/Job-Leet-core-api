using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class RegisterUserModel : BaseModel
    {
        [JsonIgnore]
        public string? Salt { get; set; }
        [Required(ErrorMessage = "Username is required")]
        // [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username contains invalid characters.")]
        // public string UserName { get; set; }
        public PersonNameModel PersonName {get; set;}
        [Required(ErrorMessage = "User email is required")]
        public EmailModel UserEmail { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(101, ErrorMessage = "Password must be between 8 and 100 characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string Password { get; set; }
        
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [StringLength(101, ErrorMessage = "Password must be between 8 and 100 characters", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        public string ConfirmPassword { get; set; }
        
    }
}
