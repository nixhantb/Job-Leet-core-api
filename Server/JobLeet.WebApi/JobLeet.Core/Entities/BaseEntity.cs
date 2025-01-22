using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities;

public class BaseEntity
{
    public int Id { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}
