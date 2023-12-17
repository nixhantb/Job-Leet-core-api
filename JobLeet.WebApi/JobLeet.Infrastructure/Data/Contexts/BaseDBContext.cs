using JobLeet.WebApi.JobLeet.Core.Entities;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using Microsoft.EntityFrameworkCore;
namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>(e =>
            {
                e.ToTable("Email");
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).HasColumnName("email_id");
                e.Property(e => e.EmailType).HasColumnName("email_type");
                e.Property(e => e.EmailAddress).HasColumnName("email_address");
                e.OwnsOne(email => email.MetaData);
            });

            // Configure MetaData as owned by BaseEntity
            modelBuilder.Entity<BaseEntity>().OwnsOne(b => b.MetaData);

            // Seed data for Email with MetaDat

            base.OnModelCreating(modelBuilder);
        }
    }
}
