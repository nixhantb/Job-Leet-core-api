namespace JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1
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
