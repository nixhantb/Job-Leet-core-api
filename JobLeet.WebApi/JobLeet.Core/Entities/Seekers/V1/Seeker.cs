using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1.Users;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Proficiencies;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualifications;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1
{
    public class Seeker : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("PersonName")]
        public int PersonNameId { get; set; }
        public PersonName PersonName { get; set; }

        [ForeignKey("Phone")]
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Skill")]
        public int SkillsId { get; set; }
        public Skill Skills { get; set; }

        [ForeignKey("Education")]
        public int EducationId { get; set; }
        public Education Education { get; set; }

        [ForeignKey("Experience")]
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }

        public DateTime DateOfBirth { get; set; }

        [ForeignKey("Qualification")]
        public int QualificationsId { get; set; }
        public Qualification Qualifications { get; set; }
    }
}
