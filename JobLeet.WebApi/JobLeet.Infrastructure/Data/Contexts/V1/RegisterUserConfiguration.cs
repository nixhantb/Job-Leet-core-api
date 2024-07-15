using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class RegisterUserConfiguration : IEntityTypeConfiguration<RegisterUser>
    {
        public void Configure(EntityTypeBuilder<RegisterUser> builder)
        {
            builder.ToTable("jblt_registerUser");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("jblt_registerid");
            builder.Property(e => e.Password).HasColumnName("jblt_password");
            builder.Property(e => e.ConfirmPassword).HasColumnName("jblt_confirmpassword");
            builder.OwnsOne(register => register.MetaData);
        }
    }
}
