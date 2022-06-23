using DataAccess.Model.EntityTypeConfigurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<BrandColor> BrandColors { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F2R4JB0\MSSQLKD7;Initial Catalog=RentACar;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BrandColorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarColorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ColorEntityTypeConfiguration());

        }
    }
}
