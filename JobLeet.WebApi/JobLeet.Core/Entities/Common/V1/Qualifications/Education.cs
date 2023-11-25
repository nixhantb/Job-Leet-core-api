namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualifications
{
    public class Education : BaseEntity
    {
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Institution { get; set; }
        public DateOnly GraduationDate {  get; set; }
        public Decimal Cgpa {  get; set; }
    }
}
