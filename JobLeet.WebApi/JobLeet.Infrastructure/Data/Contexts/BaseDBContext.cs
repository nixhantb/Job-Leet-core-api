using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts.V1;
using Microsoft.EntityFrameworkCore;
namespace JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options)
        {
        }
        #region Entity Configuration

        // Entities must be passed into the DbSet for mapping purposes in Repository classes
        // Define DbSet properties for each entity in the DbContext
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<PersonName> PersonNames { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<JobEntity> JobEntity {get; set;}
        public virtual DbSet<IndustryType> IndustryTypes {get; set;}
        public virtual DbSet<CompanyProfile> CompanyProfiles {get; set;}
        public virtual DbSet<Company> Companies {get; set;}


        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new PersonNameConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new QualificationConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RegisterUserConfiguration());
            modelBuilder.ApplyConfiguration(new LoginUserConfiguration());
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new IndustryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<IndustryType>();
        }
    }
}