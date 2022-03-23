using WeatherAPI.Helper;

namespace WeatherAPI.Models;

public class Root
{
    public int Id { get; set; }
    public List<Weather>? Weather { get; set; }

    public int MainId { get; set; }
    public Main? Main { get; set; }

    public int WindId { get; set; }
    public Wind? Wind { get; set; }

    public int CloudsId { get; set; }
    public Clouds? Clouds { get; set; }

    public int SysId { get; set; }
    public Sys? Sys { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Dt { get; set; } = DateTimeHelper.ConvertDatetimeToUnixTimeStamp(DateTime.Now).ToString();
}
