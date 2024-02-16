using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class PersonNameConfiguration : IEntityTypeConfiguration<PersonName>
    {
        public void Configure(EntityTypeBuilder<PersonName> builder)
        {
            builder.ToTable("PersonName");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("personname_id");
            builder.Property(e => e.FirstName).HasColumnName("first_name");
            builder.Property(e => e.MiddleName).HasColumnName("middle_name");
            builder.Property(e => e.LastName).HasColumnName("last_name");
        }
    }
}
