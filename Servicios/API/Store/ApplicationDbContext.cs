using Microsoft.EntityFrameworkCore;
using System;
using DbModels;

namespace Store
{
    public class AplicattionDbContext: DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= LAPTOP-5EMM6JNC ; Initial Catalog= Flay ; Integrated Security = True")
                .EnableSensitiveDataLogging(true);
        }

        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Renter> Renter { get; set; }
    }
}
