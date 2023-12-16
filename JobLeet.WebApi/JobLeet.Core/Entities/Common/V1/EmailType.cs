using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class EmailType : BaseEntity
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EmailCategory EmailCategory { get; set; }
    }
    public enum EmailCategory
    {
        [Display(Name = "Personal")]
        Personal,
        [Display(Name = "Work")]
        Work,
        [Display(Name = "Other")]
        Other
    }
}
