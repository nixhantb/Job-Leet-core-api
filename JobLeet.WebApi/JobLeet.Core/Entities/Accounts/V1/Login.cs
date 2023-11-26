using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
{
    public class Login : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public bool AccountCreated { get; set; } = false;
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public DateTime? LogoutTime { get; set; }
        public string IPAddress { get; set; }


    }
    public enum AccountStatus
    {
        Active,
        Inactive,
        Suspended,
        Locked,
        Pending
    }
}
