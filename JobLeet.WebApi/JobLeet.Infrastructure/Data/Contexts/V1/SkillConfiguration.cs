using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("jblt_skill");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("skill_id");
            builder.Property(e => e.Title).HasColumnName("skill_title");
            builder.Property(e => e.Description).HasColumnName("skill_description");
            builder.OwnsOne(skill => skill.MetaData);
        }
    }
}
