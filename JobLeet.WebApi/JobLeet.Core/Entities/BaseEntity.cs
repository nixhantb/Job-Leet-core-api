using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Core.Entities;
public class BaseEntity
{
    public int Id { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();

}


