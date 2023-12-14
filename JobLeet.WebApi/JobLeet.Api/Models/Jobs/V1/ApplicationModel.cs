namespace JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1
{
    public class ApplicationModel : BaseModel
    {
        public StatusModel Status { get; set; }
        public ApplicationDateModel Date { get; set; }
        
    }
}
