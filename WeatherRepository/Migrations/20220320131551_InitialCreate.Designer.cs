﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherRepository;

#nullable disable

namespace WeatherRepository.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20220320131551_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("WeatherRepository.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "DE",
                            Name = "Erfurt"
                        },
                        new
                        {
                            Id = 2,
                            Country = "DE",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 3,
                            Country = "DE",
                            Name = "Bremen"
                        },
                        new
                        {
                            Id = 4,
                            Country = "DE",
                            Name = "Leipzig"
                        },
                        new
                        {
                            Id = 5,
                            Country = "DE",
                            Name = "Hamburg"
                        },
                        new
                        {
                            Id = 6,
                            Country = "DE",
                            Name = "München"
                        },
                        new
                        {
                            Id = 7,
                            Country = "DE",
                            Name = "Hannover"
                        },
                        new
                        {
                            Id = 8,
                            Country = "DE",
                            Name = "Köln"
                        },
                        new
                        {
                            Id = 9,
                            Country = "DE",
                            Name = "Dresden"
                        },
                        new
                        {
                            Id = 10,
                            Country = "DE",
                            Name = "Stuttgart"
                        });
                });

            modelBuilder.Entity("WeatherRepository.Model.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CloudCoverage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IconId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MaxTemperature")
                        .HasColumnType("REAL");

                    b.Property<double>("MinTemperature")
                        .HasColumnType("REAL");

                    b.Property<int>("Pressure")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Temperature")
                        .HasColumnType("REAL");

                    b.Property<int>("WindDirection")
                        .HasColumnType("INTEGER");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Weathers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            CloudCoverage = 90,
                            Description = "bedeckt",
                            Humidity = 11,
                            IconId = 1,
                            MaxTemperature = 17.0,
                            MinTemperature = 8.0,
                            Pressure = 1003,
                            Temperature = 21.0,
                            WindDirection = 158,
                            WindSpeed = 9.3794831268468464
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CloudCoverage = 0,
                            Description = "sonnig",
                            Humidity = 40,
                            IconId = 0,
                            MaxTemperature = 34.0,
                            MinTemperature = 34.0,
                            Pressure = 1005,
                            Temperature = 51.0,
                            WindDirection = 61,
                            WindSpeed = 4.5143023900553993
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            CloudCoverage = 27,
                            Description = "bedeckt",
                            Humidity = 94,
                            IconId = 1,
                            MaxTemperature = 23.0,
                            MinTemperature = 17.0,
                            Pressure = 1006,
                            Temperature = 31.5,
                            WindDirection = 92,
                            WindSpeed = 3.7478184359168756
                        },
                        new
                        {
                            Id = 4,
                            CityId = 4,
                            CloudCoverage = 56,
                            Description = "bedeckt",
                            Humidity = 37,
                            IconId = 1,
                            MaxTemperature = 28.0,
                            MinTemperature = 24.0,
                            Pressure = 1007,
                            Temperature = 40.0,
                            WindDirection = 269,
                            WindSpeed = 4.1226409651278759
                        },
                        new
                        {
                            Id = 5,
                            CityId = 5,
                            CloudCoverage = 45,
                            Description = "sonnig",
                            Humidity = 81,
                            IconId = 0,
                            MaxTemperature = 32.0,
                            MinTemperature = 24.0,
                            Pressure = 1011,
                            Temperature = 44.0,
                            WindDirection = 111,
                            WindSpeed = 0.12418574304075891
                        },
                        new
                        {
                            Id = 6,
                            CityId = 6,
                            CloudCoverage = 60,
                            Description = "regnerisch",
                            Humidity = 62,
                            IconId = 2,
                            MaxTemperature = 39.0,
                            MinTemperature = 30.0,
                            Pressure = 1010,
                            Temperature = 54.0,
                            WindDirection = 114,
                            WindSpeed = 9.4264920763261539
                        },
                        new
                        {
                            Id = 7,
                            CityId = 7,
                            CloudCoverage = 3,
                            Description = "sonnig",
                            Humidity = 19,
                            IconId = 0,
                            MaxTemperature = 15.0,
                            MinTemperature = 15.0,
                            Pressure = 1004,
                            Temperature = 22.5,
                            WindDirection = 119,
                            WindSpeed = 3.2139106277734442
                        },
                        new
                        {
                            Id = 8,
                            CityId = 8,
                            CloudCoverage = 65,
                            Description = "bedeckt",
                            Humidity = 94,
                            IconId = 1,
                            MaxTemperature = 48.0,
                            MinTemperature = 39.0,
                            Pressure = 1003,
                            Temperature = 67.5,
                            WindDirection = 11,
                            WindSpeed = 9.0963352348100628
                        },
                        new
                        {
                            Id = 9,
                            CityId = 9,
                            CloudCoverage = 28,
                            Description = "bedeckt",
                            Humidity = 71,
                            IconId = 1,
                            MaxTemperature = 23.0,
                            MinTemperature = 20.0,
                            Pressure = 1019,
                            Temperature = 33.0,
                            WindDirection = 79,
                            WindSpeed = 3.4374587839576973
                        },
                        new
                        {
                            Id = 10,
                            CityId = 10,
                            CloudCoverage = 86,
                            Description = "regnerisch",
                            Humidity = 40,
                            IconId = 2,
                            MaxTemperature = 12.0,
                            MinTemperature = 12.0,
                            Pressure = 1016,
                            Temperature = 18.0,
                            WindDirection = 256,
                            WindSpeed = 6.9459530975075277
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
