using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1;
using Microsoft.EntityFrameworkCore;
namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
