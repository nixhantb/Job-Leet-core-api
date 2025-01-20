using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
{
    public class Role : BaseEntity
    {
        public RoleCategory RoleName { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoleCategory
    {
        [Display(Name = "Admin")]
        Admin = 1,

        [Display(Name = "Users")]
        Users = 2,
    }
}
