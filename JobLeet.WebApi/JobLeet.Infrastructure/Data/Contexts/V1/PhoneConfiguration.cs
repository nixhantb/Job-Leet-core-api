using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("Phone");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("phone_id");
            builder.Property(e => e.CountryCode).HasColumnName("country_code");
            builder.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            builder.OwnsOne(phone => phone.MetaData);
        }
    }
}
