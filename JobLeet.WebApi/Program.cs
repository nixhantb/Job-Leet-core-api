using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using Microsoft.EntityFrameworkCore;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

builder.Services.AddControllers();
builder.Services.AddScoped<DbContext, BaseDBContext>();
builder.Services.AddScoped<IEmaiTypeRepository, EmailTypeRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<BaseDBContext>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("jobleetconnect"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("jobleetconnect")));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
