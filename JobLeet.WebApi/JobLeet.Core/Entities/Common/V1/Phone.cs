using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class Phone : BaseEntity
    {
        [Required(ErrorMessage = "Country Code is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Country Code must be a positive number")]
        public int CountryCode { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Phone Number format. Use only digits.")]
        public string PhoneNumber { get; set; }
    }
}
