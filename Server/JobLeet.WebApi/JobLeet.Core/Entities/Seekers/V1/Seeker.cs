using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1
{
    public class Seeker : BaseEntity
    {
        public PersonName PersonName { get; set; }
        public Phone? Phone { get; set; }
        public Address? Address { get; set; }
        public Skill? Skills { get; set; }
        public Education? Education { get; set; }
        public Experience? Experience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Qualification? Qualifications { get; set; }
        public string? ProfileSummary { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
        public List<string>? Interests { get; set; }
        public List<string>? Achievements { get; set; }
    }

    public class SocialMedia : BaseEntity
    {
        public string? Title { get; set; }
        public string? Url { get; set; }
    }
}
