using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
       public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Education");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("education_id");
            builder.Property(e => e.Degree).HasColumnName("degree");
            builder.Property(e => e.Major).HasColumnName("major");
            builder.Property(e => e.Institution).HasColumnName("institution");
            builder.Property(e => e.GraduationDate).HasColumnName("graduation_date");
            builder.Property(e => e.Cgpa).HasColumnName("cgpa");
            builder.OwnsOne(education => education.MetaData);
        }
    }
}
