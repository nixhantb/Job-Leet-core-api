using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class LoginUserConfiguration : IEntityTypeConfiguration<LoginUser>
    {
        public void Configure(EntityTypeBuilder<LoginUser> builder)
        {
            builder.ToTable("LoginUser");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("login_id");
            builder.Property(e => e.EmailAddress).HasColumnName("email_address");
            builder.Property(e => e.Password).HasColumnName("password");
            builder.Property(e => e.AccountStatus).HasColumnName("account_status");
            builder.Property(e => e.AccountCreated).HasColumnName("account_created");
            builder.Property(e => e.LoginTime).HasColumnName("login_time");
            builder.Property(e => e.IPAddress).HasColumnName("ip_address");
            builder.Property(e => e.Role).HasColumnName("role");
            builder.OwnsOne(login => login.MetaData);
        }
    }
}

