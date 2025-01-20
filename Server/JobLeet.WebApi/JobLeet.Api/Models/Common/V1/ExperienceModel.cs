using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class ExperienceModel : BaseModel
    {
        public ExperienceLevel ExperienceLevel { get; set; }
        public CompanyModel? CompanyModel { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExperienceLevel
    {
        [Display(Name = "EntryLevel")]
        EntryLevel = 1,

        [Display(Name = "Intermediate")]
        Intermediate = 2,

        [Display(Name = "Senior")]
        Senior = 3,

        [Display(Name = "Lead")]
        Lead = 4,

        [Display(Name = "Principal")]
        Principal = 5,

        [Display(Name = "Executive")]
        Executive = 6,

        [Display(Name = "Others")]
        Others = 7,
    }
}
