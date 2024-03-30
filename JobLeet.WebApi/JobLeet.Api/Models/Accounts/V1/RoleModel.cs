using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class RoleModel : BaseModel
    {
        public RoleName RoleName { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoleName
    {
        [Display(Name = "Admin")]
        Admin = 1,
        [Display(Name = "Users")]
        Users = 2
    }

}

