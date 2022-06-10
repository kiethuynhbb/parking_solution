using App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.EntityMappers
{
    public class ParkingMap : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            var entitybuilder = builder.ToTable("Parking");
            entitybuilder.HasKey(x => x.Id)
                   .HasName("pk_parking");

            entitybuilder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");

            entitybuilder.Property(x => x.CardNo)
                   .HasColumnName("CardNo")
                   .HasColumnType("INT")
                   .IsRequired();

            entitybuilder.Property(x => x.LevelId)
                   .HasColumnName("LevelId")
                   .HasColumnType("INT")
                    .IsRequired();

            entitybuilder.Property(x => x.VehicleId)
                 .HasColumnName("VehicleId")
                 .HasColumnType("INT")
                 .IsRequired();

            entitybuilder.Property(x => x.FromDate)
                 .HasColumnName("FromDate")
                 .HasColumnType("DATETIME")
                 .IsRequired();

            entitybuilder.Property(x => x.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("DATETIME");

            entitybuilder.HasOne<Vehicle>(s => s.Vehicle)
                 .WithMany(g => g.Parkings)
                 .HasForeignKey(s => s.VehicleId)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_parking_vehicle");

            entitybuilder.HasOne<Level>(s => s.Level)
                 .WithMany(g => g.Parkings)
                 .HasForeignKey(s => s.LevelId)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_parking_level");
        }
    }
}
