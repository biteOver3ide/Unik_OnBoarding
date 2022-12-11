using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Unik_OnBoarding.Persistance.DbContext;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=Unik_OnBoardingDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        return new AppDbContext(optionsBuilder.Options);
    }
}