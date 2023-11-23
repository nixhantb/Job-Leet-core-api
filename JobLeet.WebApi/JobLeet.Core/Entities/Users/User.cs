using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Users
{
    public class User: BaseEntity
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int RoleId {  get; set; }

    }
}
