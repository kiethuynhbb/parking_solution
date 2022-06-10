using App.DataProvider.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.SeedData
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1, Type = 1, Name = "Honda" , LicenseNo = "70FN0007678", ProvidedDate = new DateTime(2018, 7, 24), ProvidedBy = 99 },
                new Vehicle { Id = 2, Type = 1, Name = "Yamaha", LicenseNo = "50RM2344556", ProvidedDate = new DateTime(2018, 7, 24), ProvidedBy = 99 }
            );

            modelBuilder.Entity<Level>().HasData(
                new Level
                {
                    Id = 1,
                    LevelNo = 1,
                }
            );

            modelBuilder.Entity<Capacity>().HasData(
                new Capacity
                {
                    Id = 1,
                    Amount = 500,
                    InActive = false,
                    LevelId = 1
                }
            );

            modelBuilder.Entity<Parking>().HasData(
                new Parking
                {
                    Id = 1,
                    LevelId = 1,
                    VehicleId = 1,
                    FromDate = new DateTime(2022, 7, 23, 08, 20, 10),
                    EndDate = null
                }
            );
        }
    }
}
