using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application;
using Unik_OnBoarding.Persistance;
using Unik_OnBoarding.Persistance.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AppServiceCollection();
builder.Services.AddPersistenceService();

//Docker
builder.Configuration.AddEnvironmentVariables();

// Database Migration
// Add-Migration InitialMigration 
// Update-Database 
//builder.Services.AddDbContext<Unik_OnBoardingContext>(
//    options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));

builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));


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