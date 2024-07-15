using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1
{
    public class LoginUserConfiguration : IEntityTypeConfiguration<LoginUser>
    {
        public void Configure(EntityTypeBuilder<LoginUser> builder)
        {
            builder.ToTable("jblt_loginuser");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("loginuser_id");
            builder.Property(e => e.EmailAddress).HasColumnName("loginuser_address");
            builder.Property(e => e.Password).HasColumnName("loginuser_password");
            builder.Property(e => e.AccountStatus).HasColumnName("loginuser_accountstatus");
            builder.Property(e => e.AccountCreated).HasColumnName("loginuser_accountcreated");
            builder.Property(e => e.LoginTime).HasColumnName("loginuser_logintime");
            builder.Property(e => e.IPAddress).HasColumnName("loginuser_ipaddress");
            builder.Property(e => e.Role).HasColumnName("loginuser_role");
            builder.OwnsOne(login => login.MetaData);
        }
    }
}

