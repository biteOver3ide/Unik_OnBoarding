using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Persistance.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Projekt> Projektes { get; set; }
    }
}
