using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class IndustryTypeConfiguration : IEntityTypeConfiguration<IndustryType>{
        public void Configure(EntityTypeBuilder<IndustryType> builder)
        {
            builder.ToTable("jblt_industrytype");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("industrytype_id");
            builder.Property(e => e.IndustryCategory).HasColumnName("industry_type");
            builder.OwnsOne(job => job.MetaData);
        }
    }
}