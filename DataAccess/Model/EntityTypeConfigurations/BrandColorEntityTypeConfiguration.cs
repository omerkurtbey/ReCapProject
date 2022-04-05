using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.EntityTypeConfigurations
{
    public class BrandColorEntityTypeConfiguration : IEntityTypeConfiguration<BrandColor>
    {
        public void Configure(EntityTypeBuilder<BrandColor> builder)
        {
            builder.ToTable("Marka Renk");

            builder.HasKey(x => new { x.ColorId, x.BrandId });

            builder
                .HasOne(BrandColor => BrandColor.Brand)
                .WithMany(Brand => Brand.BrandColors)
                .HasForeignKey(BrandColor => BrandColor.BrandId);

            builder
                .HasOne(BrandColor => BrandColor.Color)
                .WithMany(Color => Color.BrandColors)
                .HasForeignKey(BrandColor => BrandColor.ColorId);
        }
    }
}
