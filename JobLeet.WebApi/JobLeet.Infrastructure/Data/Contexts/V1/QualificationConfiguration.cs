using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            builder.ToTable("jblt_qualification");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("qualification_id");
            builder.Property(e => e.QualificationType).HasColumnName("qualification_type");
            builder.Property(e => e.QualificationInformation).HasColumnName("qualification_information");
            builder.OwnsOne(qualification => qualification.MetaData);

        }
    }
}
