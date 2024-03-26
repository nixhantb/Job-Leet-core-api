using System.ComponentModel.DataAnnotations;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    // education
    public class Education : BaseEntity
    {
        [Required(ErrorMessage = "Degree is required")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Major is required")]
        public string Major { get; set; }
        [Required(ErrorMessage = "Institution is required")]
        public string Institution { get; set; }
        [Required(ErrorMessage = "Graduation Date is required")]
        [DataType(DataType.Date)]
        public DateOnly GraduationDate { get; set; }
        [Range(0, 4.0, ErrorMessage = "CGPA must be between 0.0 and 4.0")]
        public decimal Cgpa { get; set; }
    }
}
