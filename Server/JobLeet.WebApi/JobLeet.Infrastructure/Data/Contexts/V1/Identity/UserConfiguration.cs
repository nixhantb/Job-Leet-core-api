using JobLeet.WebApi.JobLeet.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("jblt_Users");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("usersId");
        }
    }
}
