

namespace Meteostanice
{
    public class WeatherRecord
    {
        public int Id { get; set; }

        public DateTime RetrievedAt { get; set; }

        public string? JsonData { get; set; }

        public bool IsOnline { get; set; }
    }
}
