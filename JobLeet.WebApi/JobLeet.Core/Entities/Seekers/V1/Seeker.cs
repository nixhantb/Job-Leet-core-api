using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1
{
    public class Seeker : BaseEntity
    {
        [ForeignKey("User")]
        public User User { get; set; }
        [ForeignKey("PersonName")]
        public PersonName PersonName { get; set; }
        [ForeignKey("Phone")]
        public Phone Phone { get; set; }
        [ForeignKey("Address")]
        public Address Address { get; set; }
        [ForeignKey("Skill")]
        public Skill Skills { get; set; }
        [ForeignKey("Education")]
        public Education Education { get; set; }
        [ForeignKey("Experience")]
        public Experience Experience { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Qualification")]
        public Qualification Qualifications { get; set; }
    }
}
