using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class EmailModelType
    {
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
