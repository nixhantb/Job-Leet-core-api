namespace JobLeet.WebApi.JobLeet.Core.Entities.Roles
{
    public class Role : BaseEntity
    {
        public RoleName RoleName { get; set; }
    }

    public enum RoleName
    {
        Admin,
        Users
    }
}
