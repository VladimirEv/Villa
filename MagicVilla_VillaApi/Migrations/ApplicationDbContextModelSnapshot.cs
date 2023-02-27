﻿// <auto-generated />
using System;
using MagicVilla_VillaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaApi.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2082),
                            Details = "Master bedroom of 230 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed",
                            ImageUrl = "https://www.houzz.ru/foto/castellina-1272-model-home-phvw-vp~22592068",
                            Name = "Royal villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 350,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2094),
                            Details = "Master bedroom of 280 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 5 suites built and designed",
                            ImageUrl = "https://www.houzz.ru/foto/private-residence-the-estuary-naples-fl-phvw-vp~6599751",
                            Name = "Viki villa",
                            Occupancy = 7,
                            Rate = 450.0,
                            Sqft = 570,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2096),
                            Details = "Master bedroom of 370 m2 with open air bathroom including separated rain shower, bath tub for 4 and completed wardrobe · 4 suites built and designed",
                            ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                            Name = "Golden Sand villa",
                            Occupancy = 11,
                            Rate = 550.0,
                            Sqft = 750,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2097),
                            Details = "Master bedroom of 480 m2 with open air bathroom including separated rain shower, bath tub for 5 and completed wardrobe · 4 suites built and designed",
                            ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                            Name = "Viliam villa",
                            Occupancy = 15,
                            Rate = 800.0,
                            Sqft = 1050,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2098),
                            Details = "Master bedroom of 580 m2 with open air bathroom including separated rain shower, bath tub for 7 and completed wardrobe · 4 suites built and designed",
                            ImageUrl = "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM",
                            Name = "Teritorial villa",
                            Occupancy = 25,
                            Rate = 1250.0,
                            Sqft = 1650,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
