
using Microsoft.EntityFrameworkCore;
using App.Entities;
using Application.Common.Interfaces;
using System.Threading.Tasks;
using App.DataProvider.EntityMappers;
using DataAccessLayer.SeedData;
using Microsoft.Data.Sqlite;

namespace App.DataProvider
{
    public class ParkingBoundedContext : DbContext
    {
        public ParkingBoundedContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<Level> Level { get; set; }

        public DbSet<Capacity> Capacity { get; set; }

        public DbSet<Parking> Parking { get; set; }

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

