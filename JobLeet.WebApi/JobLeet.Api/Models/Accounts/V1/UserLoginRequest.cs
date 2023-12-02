namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class UserLoginRequest : BaseModel
    {

        public string UserName { get; set; }
        public string Password { get; set; }

    }
}

