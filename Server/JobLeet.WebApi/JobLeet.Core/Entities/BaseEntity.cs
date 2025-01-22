using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Core.Entities;

public class BaseEntity
{
    [JsonIgnore]
    public int Id { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonIgnore]
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}
