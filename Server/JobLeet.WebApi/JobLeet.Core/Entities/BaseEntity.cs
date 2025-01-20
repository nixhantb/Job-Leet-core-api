using System.ComponentModel.DataAnnotations.Schema;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities;

public class BaseEntity
{
    public int Id { get; set; }

    [NotMapped]
    public virtual MetaData MetaData { get; set; } = new MetaData();
}
