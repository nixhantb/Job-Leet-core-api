using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class QualificationModel : BaseModel
    {
        [Required(ErrorMessage = "Qualification Type is required")]

        public QualificationCategory QualificationType { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? QualificationInformation { get; set; }
    }
    
}
