using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1
{
    public class Seeker : BaseEntity
    {
        public LoginUser LoginUser {get; set;}
        public Phone? Phone { get; set; }
        public Address? Address { get; set; }
        public Skill? Skills { get; set; }
        public Education? Education { get; set; }
        public Experience? Experience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Qualification? Qualifications { get; set; }
    }
}
