using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.EntityTypeConfigurations
{
    public class CarColorEntityTypeConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("Araba Renk");

            builder.HasKey(x => new { x.ColorId, x.CarId });

            builder
                .HasOne(CarColor => CarColor.Car)
                .WithMany(Car => Car.CarColors)
                .HasForeignKey(CarColor => CarColor.CarId);

            builder
                .HasOne(CarColor => CarColor.Color)
                .WithMany(Color => Color.CarColors)
                .HasForeignKey(CarColor => CarColor.ColorId);

        }
    }
}
