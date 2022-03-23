using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherRepository.Model;

namespace WeatherRepository;

public class WeatherContext : DbContext
{
    public DbSet<City> Cities { get; set; }

    public DbSet<Weather> Weathers { get; set; }

    private readonly string _connectionString;

    public WeatherContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=WeatherDB.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var rnd = new Random();
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Erfurt", Country = "DE" },
            new City { Id = 2, Name = "Berlin", Country = "DE" },
            new City { Id = 3, Name = "Bremen", Country = "DE" },
            new City { Id = 4, Name = "Leipzig", Country = "DE" },
            new City { Id = 5, Name = "Hamburg", Country = "DE" },
            new City { Id = 6, Name = "München", Country = "DE" },
            new City { Id = 7, Name = "Hannover", Country = "DE" },
            new City { Id = 8, Name = "Köln", Country = "DE" },
            new City { Id = 9, Name = "Dresden", Country = "DE" },
            new City { Id = 10, Name = "Stuttgart", Country = "DE" }
        );

        for (int i = 1; i <= 10; i++)
        {
            modelBuilder.Entity<Weather>().HasData(CreateWeatherData(i));
        }
    }

    private Weather CreateWeatherData (int cityId)
    {
        var rnd = new Random();
        var weather = new Weather { Id = cityId, CityId = cityId, MinTemperature =  rnd.Next(0, 40), Pressure = 1013 + rnd.Next(-10, 10), Humidity = rnd.Next(5,99), CloudCoverage = rnd.Next(0,100), WindDirection = rnd.Next(0,359), WindSpeed = 10 * rnd.NextDouble() };

        var weatherConditions = new string[] { "sonnig", "bedeckt", "regnerisch" };
        weather.MaxTemperature = weather.MinTemperature + rnd.Next(10);
        weather.Temperature = weather.MaxTemperature + weather.MinTemperature / 2;
        weather.IconId = rnd.Next(3);
        weather.Description = weatherConditions[weather.IconId];

        return weather;
    }
}
