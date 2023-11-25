namespace JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Profiles
{
    public class Education
    {
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Institution { get; set; }
        public DateOnly GraduationDate {  get; set; }
        public decimal Cgpa {  get; set; }

    }
}
