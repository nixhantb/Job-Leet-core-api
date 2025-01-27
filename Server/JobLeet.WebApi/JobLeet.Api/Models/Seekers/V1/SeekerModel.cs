using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models.Seekers.V1
{
    public class SeekerModel : BaseModel
    {
        public PersonNameModel personNameModel { get; set; }
        public PhoneModel? Phone { get; set; }
        public AddressModel? Address { get; set; }
        public SkillModel? Skills { get; set; }
        public EducationModel? Education { get; set; }
        public ExperienceModel? Experience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public QualificationModel? Qualifications { get; set; }
        public string? ProfileSummary { get; set; }
        public List<SocialMedia> SocialMedias { get; set; } = new List<SocialMedia>();
        public List<string>? Interests { get; set; }
        public List<string>? Achievements { get; set; }
        public ProjectModel? Projects { get; set; }
    }

    public class SocialMedia : BaseModel
    {
        public string? Title { get; set; }
        public string? Url { get; set; }
    }
}
