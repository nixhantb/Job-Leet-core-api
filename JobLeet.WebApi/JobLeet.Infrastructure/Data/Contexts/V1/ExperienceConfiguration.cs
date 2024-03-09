using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experience");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("experience_id");
            builder.Property(e => e.ExperienceLevel).HasColumnName("experience_type");
            builder.OwnsOne(experience => experience.MetaData);
            
        }
    }
}
