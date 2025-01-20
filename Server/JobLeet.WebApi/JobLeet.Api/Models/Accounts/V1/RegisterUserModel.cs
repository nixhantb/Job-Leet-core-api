using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class RegisterUserModel : BaseModel
    {
        [JsonIgnore]
        public string? Salt { get; set; }

        [Required(ErrorMessage = "personName is a required field")]
        public PersonNameModel PersonName { get; set; }

        [Required(ErrorMessage = "userEmail is a required field")]
        public EmailModel UserEmail { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public string ConfirmPassword { get; set; }
    }
}
