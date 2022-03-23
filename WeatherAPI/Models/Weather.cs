namespace WeatherAPI.Models;

public class Weather
{
    public int Id { get; set; }

    public int RootId { get; set; }
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}
