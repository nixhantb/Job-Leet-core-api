using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class UserTokensConfiguration : IEntityTypeConfiguration<UserTokens>
    {
        public void Configure(EntityTypeBuilder<UserTokens> builder)
        {
            builder.ToTable("jblt_UserTokens");
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.UserId).HasColumnName("usertokensId");
        }
    }
}
