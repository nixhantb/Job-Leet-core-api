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
        // Entities must be passed into the DbSet for mapping purposes in Repository classes
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<PersonName> PersonNames { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new PersonNameConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new QualificationConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
