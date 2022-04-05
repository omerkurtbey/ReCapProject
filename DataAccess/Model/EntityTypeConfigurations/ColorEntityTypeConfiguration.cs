using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model.EntityTypeConfigurations
{
    public class ColorEntityTypeConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Renkler");

            builder.HasKey(x => x.ColorId);
            builder.Property(x => x.ColorId).UseIdentityColumn();

            builder.Property(x => x.ColorName).IsRequired();
            builder.Property(x => x.ColorName).HasMaxLength(100);

            builder.HasData(
                new Color () { ColorId = 1, ColorName = "Siyah"},
                new Color () { ColorId = 2, ColorName = "Beyaz"},
                new Color () { ColorId = 3, ColorName = "Gri"},
                new Color () { ColorId = 4, ColorName = "Kırmızı"}
                );
        }
    }
}
