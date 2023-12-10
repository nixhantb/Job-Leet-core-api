using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class UserLoginRequest : BaseUserRequest
    {
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address format")]
        public new string EmailAddress
        {
            get => Email.EmailAddress;
            set => Email.EmailAddress = value;
        }
    }
}

