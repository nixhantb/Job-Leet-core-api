using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Qualification : BaseEntity
    {
        [Required(ErrorMessage = "Qualification Type is required")]
        public QualificationCategory QualificationType { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? QualificationInformation { get; set; }
    }

}
