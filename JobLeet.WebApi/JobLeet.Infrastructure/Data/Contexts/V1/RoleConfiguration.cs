using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        
        {
            builder.ToTable("Role");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("role_id");
            builder.Property(e => e.RoleName).HasColumnName("role_name");
            builder.OwnsOne(role => role.MetaData);
        }
    }
}
