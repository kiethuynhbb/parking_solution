using App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.EntityMappers
{
    public class CapacityMap : IEntityTypeConfiguration<Capacity>
    {
        public void Configure(EntityTypeBuilder<Capacity> builder)
        {
            var entitybuilder = builder.ToTable("Capacity");
            entitybuilder.HasKey(x => x.Id)
                   .HasName("pk_capacity");

            entitybuilder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("INT");

            entitybuilder.Property(x => x.Amount)
                 .HasColumnName("Amount")
                 .HasColumnType("INT")
                 .IsRequired();

            entitybuilder.Property(x => x.InActive)
                 .HasColumnName("InActive")
                 .HasColumnType("BIT");

            entitybuilder.Property(x => x.LevelId)
               .HasColumnName("LevelId")
               .HasColumnType("INT");

            entitybuilder.HasOne<Level>(s => s.Level)
                  .WithMany(g => g.Capacities)
                  .HasForeignKey(s => s.LevelId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_level_capacity");
        }
    }
}
