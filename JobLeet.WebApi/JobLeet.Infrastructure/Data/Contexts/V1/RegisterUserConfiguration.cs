using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class RegisterUserConfiguration : IEntityTypeConfiguration<RegisterUser>
    {
        public void Configure(EntityTypeBuilder<RegisterUser> builder)
        {
            builder.ToTable("RegisterUser");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("register_id");
            builder.Property(e => e.UserName).HasColumnName("username");
            builder.Property(e => e.Password).HasColumnName("password");
            builder.Property(e => e.ConfirmPassword).HasColumnName("confirm_password");
            builder.OwnsOne(register => register.MetaData);
        }
    }
}
