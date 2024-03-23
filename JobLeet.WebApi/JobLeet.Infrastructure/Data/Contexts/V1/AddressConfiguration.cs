using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("AddressId");
            builder.Property(e => e.Street).HasColumnName("Street");
            builder.Property(e => e.City).HasColumnName("City");
            builder.Property(e => e.State).HasColumnName("State");
            builder.Property(e => e.PostalCode).HasColumnName("PostalCode");
            builder.Property(e => e.Country).HasColumnName("Country");
            builder.OwnsOne(Address => Address.MetaData);
        }
    }
}
