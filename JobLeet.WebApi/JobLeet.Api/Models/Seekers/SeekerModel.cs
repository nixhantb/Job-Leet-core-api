using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Seekers
{
    public class SeekerModel : BaseModel
    {
        public PersonNameModel PersonName {  get; set; }
        public PhoneModel Phone { get; set; }
        public AddressModel Address { get; set; }
        public SkillModel Skills { get; set; }
        public EducationModel Education { get; set; }
        public ExperienceModel Experience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public QualificationModel Qualifications { get; set; }
    }
}
