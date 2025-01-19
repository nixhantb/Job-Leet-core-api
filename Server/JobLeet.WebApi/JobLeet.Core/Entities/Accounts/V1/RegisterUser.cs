using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
{
    public class RegisterUser : BaseEntity
    {
        [JsonIgnore]
        public string? Salt { get; set; }
        public PersonName PersonName { get; set; }

        public Email UserEmail { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
