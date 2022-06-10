using App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.EntityMappers
{
    public class LicensePlateMap : IEntityTypeConfiguration<LicensePlate>
    {
        public void Configure(EntityTypeBuilder<LicensePlate> builder)
        {
            var entitybuilder = builder.ToTable("LicensePlate");
            entitybuilder.HasKey(x => x.Id)
                       .HasName("pk_license");

           
        }
    }
}
