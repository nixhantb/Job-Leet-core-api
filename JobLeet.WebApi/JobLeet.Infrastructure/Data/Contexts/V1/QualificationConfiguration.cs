using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builer)
        {
            builer.ToTable("Qualification");
            builer.HasKey(e => e.Id);
            builer.Property(e => e.Id).HasColumnName("qualification_id");
            builer.Property(e => e.QualificationType).HasColumnName("qualification_type");
            builer.Property(e => e.QualificationInformation).HasColumnName("qualification_information");
            builer.OwnsOne(qualification => qualification.MetaData);

        }
    }
}
