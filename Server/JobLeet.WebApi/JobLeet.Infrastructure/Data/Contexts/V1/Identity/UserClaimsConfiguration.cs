using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class UserClaimsConfiguration : IEntityTypeConfiguration<UserClaims>
    {
        public void Configure(EntityTypeBuilder<UserClaims> builder)
        {
            builder.ToTable("jblt_UserClaims");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("userclaimsId");
        }
    }
}
