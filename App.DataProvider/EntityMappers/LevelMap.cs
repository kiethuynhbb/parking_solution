using App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.EntityMappers
{
    public class LevelMap : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            var entitybuilder = builder.ToTable("Level");
            entitybuilder.HasKey(x => x.Id)
                   .HasName("pk_Level");

            entitybuilder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("INT")
                   .IsRequired();

            entitybuilder.Property(x => x.LevelNo)
                   .HasColumnName("LevelNo")
                   .HasColumnType("INT");

        }
    }
}
