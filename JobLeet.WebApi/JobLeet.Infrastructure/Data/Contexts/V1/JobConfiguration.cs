using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class JobConfiguration : IEntityTypeConfiguration<JobEntity>{
        public void Configure(EntityTypeBuilder<JobEntity> builder)
        {
            builder.ToTable("jblt_job");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("job_id");
            builder.Property(e => e.JobTitle).HasColumnName("job_title");
            builder.Property(e => e.JobDescription).HasColumnName("job_description");
            builder.Property(e => e.JobDescription).HasColumnName("job_vacancies");
            builder.Property(e => e.BasicPay).HasColumnName("job_basicPay");
            builder.Property(e => e.FunctionalArea).HasColumnName("job_functionalarea");
            builder.Property(e => e.PostingDate).HasColumnName("job_postingDate");
            builder.OwnsOne(job => job.MetaData);
        }
    }
}