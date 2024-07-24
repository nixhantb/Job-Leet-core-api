using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.EntityFrameworkCore;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Exceptions.CustomExceptionWrappers.V1;
using JobLeet.WebApi.JobLeet.Api.Caching;
using JobLeet.WebApi.JobLeet.Api.Security.Headers;
using JobLeet.WebApi.JobLeet.Api.Middlewares.TotalXCount;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Extensions;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Helpers;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Consumer;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Jobs.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Jobs.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Seekers.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using JobLeet.WebApi.JobLeet.Api.Security.Jwt;
using JobLeet.WebApi.JobLeet.Api.Middlewares.JwtMiddleware;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

#region Register the repository services
// Add the required Configurations 
// Register the Repository service
builder.Services.AddControllers();
builder.Services.AddScoped<DbContext, BaseDBContext>();
builder.Services.AddScoped<IEmaiTypeRepository, EmailTypeRepository>();
builder.Services.AddSingleton<ILoggerManagerV1, LoggerManagerV1>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IPersonNameRepository, PersonNameRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<IQualificationTypeRepository, QualificationTypeRepository>();
builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRegisterUserRepository, RegisterUserRepository>();
builder.Services.AddScoped<ILoginUserRepository, LoginUserRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<ISeekerRepository, SeekersRepository>();
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


builder.Services.AddAuthentication(options =>
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
        IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(builder.Configuration["Jwt:Key"]))
    };
});

#endregion

#region Database configuration Services

builder.Services.AddDbContext<BaseDBContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("jobleetconnect"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("jobleetconnect")));
});
#endregion

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
builder.Services.AddSingleton<RabbitMQServiceSetup>();
builder.Services.AddSingleton<RabbitMQService>();
builder.Services.AddHostedService<RabbitMQConsumerService>();
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
// app.UseMiddleware<ResourceNotFoundException>();
#endregion
app.CreateDataBaseTableIfNotPresent();
app.Run();
