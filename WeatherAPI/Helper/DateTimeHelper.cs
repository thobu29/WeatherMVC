namespace WeatherAPI.Helper
{
    public static class DateTimeHelper
    {
        public static long ConvertDatetimeToUnixTimeStamp(DateTime date)
        {
            var originDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - originDate;
            return (long)Math.Floor(diff.TotalSeconds);
        }
    }
}
