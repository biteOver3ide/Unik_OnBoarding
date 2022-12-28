using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.User.Persistance;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using Unik_OnBoarding.WebApp.Infrastructure.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Docker
builder.Configuration.AddEnvironmentVariables();
Console.WriteLine(builder.Configuration.GetConnectionString("UserAppConnection"));

var connectionString = builder.Configuration.GetConnectionString("UserAppConnection");
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(connectionString,
        x => x.MigrationsAssembly("Unik_OnBoarding.Persistance.User.Migartions")));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add User Login
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    {
        {
            options.Password.RequiredLength = 5;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequireUppercase = false;
            options.SignIn.RequireConfirmedAccount = true;
        }
    })
    .AddEntityFrameworkStores<UserDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policyBulder => policyBulder.RequireClaim("Admin"));
    options.AddPolicy("MedarbejderPolicy", policyBulder => policyBulder.RequireClaim("Medarbejder"));
});
//builder.Services.AddRazorPages();
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Admin", "AdminPolicy");
    options.Conventions.AuthorizeFolder("/Kunde", "AdminPolicy");
    options.Conventions.AuthorizeFolder("/Projekt", "AdminPolicy");
});

// IHttpClientFactory
builder.Services.AddHttpClient<IKompetenceService, KompetenceService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

builder.Services.AddHttpClient<IKundeService, KundeService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

builder.Services.AddHttpClient<IBookingService, BookingService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

builder.Services.AddHttpClient<IMedarbejderService, MedarbejderService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

builder.Services.AddHttpClient<IOpgaverService, OpgaverService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

builder.Services.AddHttpClient<IProjektService, ProjektService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["UnikBaseUrl"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();