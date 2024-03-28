using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities;
public class BaseEntity
{
    public int Id { get; set; }
    [NotMapped]
    public MetaData MetaData { get; set; } = new MetaData();

}


