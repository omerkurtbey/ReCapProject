using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.EntityTypeConfigurations
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Arabalar");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100);

            builder.HasData(
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = 2011, Description = "SUV" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 5200, ModelYear = 2015, Description = "Binek" },
                new Car { Id = 3, BrandId = 2, ColorId = 4, DailyPrice = 6200, ModelYear = 2016, Description = "Binek" },
                new Car { Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 7200, ModelYear = 2018, Description = "Sport" },
                new Car { Id = 5, BrandId = 4, ColorId = 3, DailyPrice = 5200, ModelYear = 2021, Description = "Cabrio" },
                new Car { Id = 6, BrandId = 5, ColorId = 1, DailyPrice = 3000, ModelYear = 2011, Description = "SUV" },
                new Car { Id = 7, BrandId = 6, ColorId = 2, DailyPrice = 6200, ModelYear = 2015, Description = "Binek" },
                new Car { Id = 8, BrandId = 7, ColorId = 4, DailyPrice = 9200, ModelYear = 2016, Description = "Binek" },
                new Car { Id = 9, BrandId = 8, ColorId = 1, DailyPrice = 2200, ModelYear = 2018, Description = "Sport" },
                new Car { Id = 10, BrandId = 8, ColorId = 3, DailyPrice = 3200, ModelYear = 2021, Description = "Cabrio" }

                );
            builder
                .HasOne(Car => Car.Brand)
                .WithMany(Brand => Brand.Cars)
                .HasForeignKey(Car => Car.BrandId);
        }
    }
}
