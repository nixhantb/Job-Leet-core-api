using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1
{
    public class ApplicationDate : BaseEntity
    {
        [ForeignKey("Date")]
        public int DateId { get; set; }
        public Date Date { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public DateTime DecisionDate { get; set; }
        public string Comments { get; set; }


    }
}
