using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.ToTable("jblt_UserRoles");
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.UserId).HasColumnName("userrolesId");
        }
    }
}
