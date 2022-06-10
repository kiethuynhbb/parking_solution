
using Microsoft.EntityFrameworkCore;
using App.Entities;
using Application.Common.Interfaces;
using System.Threading.Tasks;
using App.DataProvider.EntityMappers;
using DataAccessLayer.SeedData;

namespace App.DataProvider
{
    public class ParkingBoundedContext : DbContext
    {
        //private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCoreDataSeed;Trusted_Connection=True;";

        public ParkingBoundedContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<Capacity> Capacities { get; set; }

        public DbSet<Parking> Parkings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleMap());
            modelBuilder.ApplyConfiguration(new LevelMap());
            modelBuilder.ApplyConfiguration(new CapacityMap());
            modelBuilder.ApplyConfiguration(new ParkingMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            

            //modelBuilder.Entity<Vehicle>()
            //    .HasKey(e => new { e.Id});

            //modelBuilder.Seed();
        }
    }
}

