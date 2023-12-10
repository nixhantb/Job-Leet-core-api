using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;


namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class UserRegisterRequest : BaseUserRequest
    {
        [Required(ErrorMessage = "Person Name is required")]
        public PersonNameModel PersonName { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Confirm Password must be at least 8 characters")]
        [Compare(nameof(Password), ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
 
    }
}
