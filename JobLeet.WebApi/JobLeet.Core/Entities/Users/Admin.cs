using System.ComponentModel.DataAnnotations.Schema;
namespace JobLeet.WebApi.JobLeet.Core.Entities.Users
{
    public class Admin : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
