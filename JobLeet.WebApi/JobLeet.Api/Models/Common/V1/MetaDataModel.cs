using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class MetaDataModel
    {
        [NotMapped]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        [NotMapped]
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
    }
}
