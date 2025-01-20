using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1
{
    public class SeekerModel : BaseModel
    {
        public PhoneModel? Phone { get; set; }
        public AddressModel? Address { get; set; }
        public SkillModel? Skills { get; set; }
        public EducationModel? Education { get; set; }
        public ExperienceModel? Experience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public QualificationModel? Qualifications { get; set; }
        public string? ProfileSummary { get; set; }
        public string? LinkedInProfile { get; set; }
        public string? Portfolio { get; set; }
        public List<string>? Interests { get; set; }
        public List<string>? Achievements { get; set; }
    }
}
