﻿// <auto-generated />
using DataAccess.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220311075428_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BrandId");

                    b.ToTable("Araba Markaları");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Mazda"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "Ford"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "Opel"
                        },
                        new
                        {
                            BrandId = 4,
                            BrandName = "Mercedes"
                        },
                        new
                        {
                            BrandId = 5,
                            BrandName = "Audi"
                        },
                        new
                        {
                            BrandId = 6,
                            BrandName = "Renault"
                        },
                        new
                        {
                            BrandId = 7,
                            BrandName = "Citroen"
                        },
                        new
                        {
                            BrandId = 8,
                            BrandName = "Hyundai"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.BrandColor", b =>
                {
                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.HasKey("ColorId", "BrandId");

                    b.HasIndex("BrandId");

                    b.ToTable("Marka Renk");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Arabalar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ColorId = 1,
                            DailyPrice = 1000m,
                            Description = "SUV",
                            ModelYear = 2011
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            ColorId = 2,
                            DailyPrice = 5200m,
                            Description = "Binek",
                            ModelYear = 2015
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            ColorId = 4,
                            DailyPrice = 6200m,
                            Description = "Binek",
                            ModelYear = 2016
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 3,
                            ColorId = 1,
                            DailyPrice = 7200m,
                            Description = "Sport",
                            ModelYear = 2018
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 4,
                            ColorId = 3,
                            DailyPrice = 5200m,
                            Description = "Cabrio",
                            ModelYear = 2021
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 5,
                            ColorId = 1,
                            DailyPrice = 3000m,
                            Description = "SUV",
                            ModelYear = 2011
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 6,
                            ColorId = 2,
                            DailyPrice = 6200m,
                            Description = "Binek",
                            ModelYear = 2015
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 7,
                            ColorId = 4,
                            DailyPrice = 9200m,
                            Description = "Binek",
                            ModelYear = 2016
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 8,
                            ColorId = 1,
                            DailyPrice = 2200m,
                            Description = "Sport",
                            ModelYear = 2018
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 8,
                            ColorId = 3,
                            DailyPrice = 3200m,
                            Description = "Cabrio",
                            ModelYear = 2021
                        });
                });

            modelBuilder.Entity("Entities.Concrete.CarColor", b =>
                {
                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.HasKey("ColorId", "CarId");

                    b.HasIndex("CarId");

                    b.ToTable("Araba Renk");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ColorId");

                    b.ToTable("Renkler");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "Siyah"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Beyaz"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Gri"
                        },
                        new
                        {
                            ColorId = 4,
                            ColorName = "Kırmızı"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.BrandColor", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("BrandColors")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "Color")
                        .WithMany("BrandColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Entities.Concrete.CarColor", b =>
                {
                    b.HasOne("Entities.Concrete.Car", "Car")
                        .WithMany("CarColors")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "Color")
                        .WithMany("CarColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Navigation("BrandColors");

                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.Navigation("CarColors");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Navigation("BrandColors");

                    b.Navigation("CarColors");
                });
#pragma warning restore 612, 618
        }
    }
}
