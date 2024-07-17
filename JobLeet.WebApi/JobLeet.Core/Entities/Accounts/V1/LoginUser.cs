using System.ComponentModel.DataAnnotations;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Newtonsoft.Json;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
{
    public class LoginUser : BaseEntity
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public PersonName? PersonName {get; set;}
        public AccountCategory AccountStatus { get; set; }
        public bool AccountCreated { get; set; } = false;
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public string? IPAddress { get; set; }
        public RoleCategory Role { get; set; }
    }

    public enum AccountCategory
    {
        [Display(Name = "Active")]
        Active = 1,
        [Display(Name = "Inactive")]
        Inactive = 2,
        [Display(Name = "Suspended")]
        Suspended = 3,
        [Display(Name = "Locked")]
        Locked = 4,
        [Display(Name = "Pending")]
        Pending = 5
    }
}
