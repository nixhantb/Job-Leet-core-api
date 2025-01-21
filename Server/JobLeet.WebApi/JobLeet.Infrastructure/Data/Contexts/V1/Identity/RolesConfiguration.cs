using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.ToTable("jblt_Roles");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("rolesId");
        }
    }
}
