using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.EntityTypeConfigurations
{
    public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Araba Markaları");

            builder.HasKey(x => x.BrandId);
            builder.Property(x => x.BrandId).UseIdentityColumn();

            builder.Property(x => x.BrandName).IsRequired();
            builder.Property(x => x.BrandName).HasMaxLength(100);
            builder.HasData(
                new Brand () { BrandId = 1, BrandName = "Mazda"},
                new Brand() { BrandId = 2, BrandName = "Ford" },
                new Brand() { BrandId = 3, BrandName = "Opel" },
                new Brand() { BrandId = 4, BrandName = "Mercedes" },
                new Brand() { BrandId = 5, BrandName = "Audi" },
                new Brand() { BrandId = 6, BrandName = "Renault" },
                new Brand() { BrandId = 7, BrandName = "Citroen" },
                new Brand() { BrandId = 8, BrandName = "Hyundai" }

                );
        }
    }
}
