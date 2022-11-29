using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application;
using Unik_OnBoarding.Persistance;
using Unik_OnBoarding.Persistance.DbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Database Migration
// Add-Migration InitialMigration 
// Update-Database 
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));

// Dependency Injection
builder.Services.AppServiceCollection();
builder.Services.AddPersistenceService();

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