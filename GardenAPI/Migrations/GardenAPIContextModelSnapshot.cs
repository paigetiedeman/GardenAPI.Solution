﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GardenAPI.Migrations
{
    [DbContext(typeof(GardenAPIContext))]
    partial class GardenAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GardenAPI.Models.Seed", b =>
                {
                    b.Property<int>("SeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companions")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DaysTillHarvest")
                        .HasColumnType("int");

                    b.Property<int>("DaysTillSprout")
                        .HasColumnType("int");

                    b.Property<string>("Enemies")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SeedName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SqFootPlant")
                        .HasColumnType("int");

                    b.Property<int>("WaterInterval")
                        .HasColumnType("int");

                    b.HasKey("SeedId");

                    b.ToTable("Seeds");
                });

            modelBuilder.Entity("GardenAPI.Models.ZipZone", b =>
                {
                    b.Property<int>("ZipZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<int>("Zone")
                        .HasColumnType("int");

                    b.HasKey("ZipZoneId");

                    b.ToTable("ZipZone");
                });
#pragma warning restore 612, 618
        }
    }
}
