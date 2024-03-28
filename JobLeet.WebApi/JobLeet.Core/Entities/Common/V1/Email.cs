using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Email : BaseEntity
    {
        [Required(ErrorMessage = "Email Type is required")]

        public EmailCategory EmailType { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address format")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmailAddress { get; set; }
    }
    
}
