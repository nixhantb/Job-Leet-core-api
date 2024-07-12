using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Email : BaseEntity
    {
        [Required(ErrorMessage = "Email Type is required")]

        public EmailCategory EmailType { get; set; }
        public Email()
        {
            EmailType = EmailCategory.Personal;
        }
        [Required(ErrorMessage = "Email Address is required")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmailAddress { get; set; }
    }
    
}
