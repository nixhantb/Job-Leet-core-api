using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Common.V1
{
    public class MetaData
    {
        [NotMapped]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
    }
}
