using Microsoft.EntityFrameworkCore;

namespace WeatherAPI.Models;

public class WeatherContext : DbContext
{
    public DbSet<Root> Roots { get; set; } 

    public WeatherContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var rnd = new Random();
        var weatherConditions = new string[] { "sonnig", "bedeckt", "regnerisch" };

        modelBuilder.Entity<Sys>().HasData(new Sys { Id = 1, Country = "DE" });
        for (int i = 1; i <= 10; i++)
        {
            modelBuilder.Entity<Main>().HasData(CreateMainData(i));
            modelBuilder.Entity<Wind>().HasData(new Wind { Id = i, Deg = rnd.Next(0, 360), Speed = Math.Round(10 * rnd.NextDouble(), 2) });
            modelBuilder.Entity<Clouds>().HasData(new Clouds { Id = i, All = rnd.Next(0, 100) });
            var iconId = rnd.Next(3);
            var cond = weatherConditions[iconId];
            modelBuilder.Entity<Weather>().HasData(new Weather { Id = i, Main = cond, Description = cond, Icon = iconId.ToString(), RootId = i});
        }
        modelBuilder.Entity<Root>().HasData(
            new Root { Id = 1, Name = "Erfurt", SysId = 1, MainId = 1, WindId = 1, CloudsId = 1, },
            new Root { Id = 2, Name = "Berlin", SysId = 1, MainId = 2, WindId = 2, CloudsId = 2, },
            new Root { Id = 3, Name = "Bremen", SysId = 1, MainId = 3, WindId = 3, CloudsId = 3, },
            new Root { Id = 4, Name = "Leipzig", SysId = 1, MainId = 4, WindId = 4, CloudsId = 4, },
            new Root { Id = 5,  Name = "Hamburg", SysId = 1, MainId = 5, WindId = 5, CloudsId = 5, },
            new Root { Id = 6, Name = "Rostock", SysId = 1, MainId = 6, WindId = 6, CloudsId = 6, },
            new Root { Id = 7, Name = "Hannover", SysId = 1, MainId = 7, WindId = 7, CloudsId = 7, },
            new Root { Id = 8, Name = "Magdeburg", SysId = 1, MainId = 8, WindId = 8, CloudsId = 8, },
            new Root { Id = 9, Name = "Dresden", SysId = 1, MainId = 9, WindId = 9, CloudsId = 9, },
            new Root { Id = 10, Name = "Stuttgart", SysId = 1, MainId = 10, WindId = 10, CloudsId = 10,});

    }

    private Main CreateMainData(int i)
    {
        var rnd = new Random();
        var main = new Main { Id = i, Humidity = rnd.Next(5, 99), Pressure = 1013 + rnd.Next(-10, 10), Temp_min = rnd.Next(0, 40) };
        main.Temp_max = main.Temp_min + rnd.Next(-10, 10);
        main.Temp = (main.Temp_max + main.Temp_min) / 2;
        return main;
    }
}
