using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class UserLoginsConfiguration : IEntityTypeConfiguration<UserLogins>
    {
        public void Configure(EntityTypeBuilder<UserLogins> builder)
        {
            builder.ToTable("jblt_UserLogins");
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.UserId).HasColumnName("userLoginId");
        }
    }
}
