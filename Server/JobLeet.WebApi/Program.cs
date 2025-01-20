using FluentValidation;
using JobLeet.WebApi.JobLeet.Api.Caching;
using JobLeet.WebApi.JobLeet.Api.Exceptions.CustomExceptionWrappers.V1;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Middlewares.Exceptions;
using JobLeet.WebApi.JobLeet.Api.Middlewares.JwtMiddleware;
using JobLeet.WebApi.JobLeet.Api.Middlewares.TotalXCount;
using JobLeet.WebApi.JobLeet.Api.Security.Headers;
using JobLeet.WebApi.JobLeet.Api.Security.Jwt;
using JobLeet.WebApi.JobLeet.Api.Validators;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Core.Services;
using JobLeet.WebApi.JobLeet.Core.Validators.Accounts;
using JobLeet.WebApi.JobLeet.Core.Validators.Jobs;
using JobLeet.WebApi.JobLeet.Core.Validators.Seekers;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Infrastructure.Extensions;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1;
using JobLeet.WebApi.JobLeet.Validator;
using JobLeet.WebApi.JobLeet.Validator.Accounts;
using JobLeet.WebApi.JobLeetInfrastructure.Repositories.Companies.V1;
using JobLeet.WebApi.JobLeetInfrastructure.Repositories.Employers.V1;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

#region Register the repository services
// Add the required Configurations
// Register the Repository service
builder.Services.AddControllers();
builder.Services.AddScoped<DbContext, BaseDBContext>();

builder.Services.AddScoped<IEmaiTypeRepository, EmailTypeRepository>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IValidator<Email>, EmailValidator>();

builder.Services.AddSingleton<ILoggerManagerV1, LoggerManagerV1>();

builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IValidator<Skill>, SkillValidator>();

builder.Services.AddScoped<IPersonNameRepository, PersonNameRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IValidator<PersonName>, PersonNameValidator>();

builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<IExperienceService, ExperienceService>();
builder.Services.AddScoped<IValidator<Experience>, ExperienceValidator>();

builder.Services.AddScoped<IQualificationTypeRepository, QualificationTypeRepository>();
builder.Services.AddScoped<IQualificationService, QualificationService>();
builder.Services.AddScoped<IValidator<Qualification>, QualificationValidator>();

builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();
builder.Services.AddScoped<IPhoneService, PhoneService>();
builder.Services.AddScoped<IValidator<Phone>, PhoneValidator>();

builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<IValidator<Education>, EducationValidator>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IValidator<Address>, AddressValidator>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();

builder.Services.AddScoped<IQualificationService, QualificationService>();

builder.Services.AddScoped<IValidator<Role>, RoleValidator>();

builder.Services.AddScoped<IRegisterUserRepository, RegisterUserRepository>();
builder.Services.AddScoped<IValidator<RegisterUser>, RegisterUserValidator>();

builder.Services.AddScoped<ILoginUserRepository, LoginUserRepository>();
builder.Services.AddScoped<IValidator<LoginUser>, LoginUserValidator>();

builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IValidator<JobEntity>, JobEntityValidator>();

builder.Services.AddScoped<ISeekerRepository, SeekersRepository>();
builder.Services.AddScoped<ISeekerService, SeekersService>();
builder.Services.AddScoped<IValidator<Seeker>, SeekerValidator>();

builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IValidator<Company>, CompanyValidator>();

builder.Services.AddScoped<IIndustryTypeRepository, IndustryTypeRepository>();
builder.Services.AddScoped<IIndustryTypeService, IndustryTypeService>();

builder.Services.AddScoped<IEmployerService, EmployerService>();
builder.Services.AddScoped<IEmployerRepository, EmployersRepository>();
builder.Services.AddScoped<IValidator<Employer>, EmployerValidator>();

builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IValidator<Application>, ApplicationValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache(); // Register IMemoryCache

// Register BaseCacheHelper<T> for caching
builder.Services.AddScoped(typeof(BaseCacheHelper<>));
#endregion

#region  JWT Configurations
var jwtKey = JwtHelper.GetOrCreateJwtKey();
var jwtKeyBase64 = Convert.ToBase64String(jwtKey);

var configuration = builder.Configuration;
builder.Configuration["Jwt:Key"] = jwtKeyBase64;

builder
    .Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = configuration["Jwt:Issuer"],
            ValidAudience = configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Convert.FromBase64String(builder.Configuration["Jwt:Key"])
            ),
        };
    });

#endregion

#region Database configuration Services

builder.Services.AddDbContext<BaseDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("jobleetconnect"));
});
#endregion

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.MapControllers();

#region Middleware Configurations
app.UseHsts();
app.UseHttpsRedirection();
app.UseMiddleware<JwtMiddleware>();
app.UseAuthorization();

// app.UseAuthentication();
// Enable CORS
app.UseCors("AllowAll");

// app.UseMiddleware<SecurityHeaders>();
// app.UseMiddleware<TotalResponseHeaderCount>();
app.UseMiddleware<ResourceNotFoundException>();

app.UseMiddleware<ExceptionMiddleware>();
#endregion
app.CreateDataBaseTableIfNotPresent();
app.Run();
