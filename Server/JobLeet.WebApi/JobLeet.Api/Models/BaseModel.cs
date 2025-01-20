using System.ComponentModel.DataAnnotations.Schema;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace JobLeet.WebApi.JobLeet.Api.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        [NotMapped]
        public virtual MetaDataModel MetaData { get; set; } = new MetaDataModel();
    }
}
