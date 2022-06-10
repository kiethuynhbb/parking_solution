using App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.EntityMappers
{
    public class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            var entitybuilder = builder.ToTable("Vehicles");
            entitybuilder.HasKey(x => x.Id)
                   .HasName("pk_vehicle");

            entitybuilder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("INT")
                   .IsRequired();

            entitybuilder.Property(x => x.Type)
                   .HasColumnName("Type")
                   .HasColumnType("NVARCHAR(100)");

            entitybuilder.Property(x => x.Name)
                   .HasColumnName("Name")
                   .HasColumnType("NVARCHAR(100)");
                   

            entitybuilder.Property(x => x.LicenseNo)
                      .HasColumnName("LicenseNo")
                      .HasColumnType("NVARCHAR(20)")
                      .IsRequired();

            entitybuilder.Property(x => x.ProvidedDate)
                       .HasColumnName("ProvidedDate")
                       .HasColumnType("DATETIME");

            entitybuilder.Property(x => x.ProvidedBy)
                      .HasColumnName("ProvidedBy")
                      .HasColumnType("INT");

            entitybuilder.Property(x => x.DeleteOn)
                      .HasColumnName("DeleteOn")
                      .HasColumnType("DATETIME");
        }
    }
}