using System.Reflection;
using Autofac.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unik_OnBoarding.Application;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Persistance;
using Unik_OnBoarding.Persistance.DbContext;
using Unik_OnBoarding.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Mirgation 
// Database
// Add-Migration InitialMigration -Context UserDbContext -Project LevSundt.Project.UserContext.Migrations
// Update-Database -Context UserDbContext
builder.Services.AddDbContext<AppDbContext>(
options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));


//builder.Services.AppServiceCollection(); // inject services from Application, extended IServicesColletion methode 
//builder.Services.AddPersistenceService();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IProjectRepository), typeof(ProjektRepository));

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