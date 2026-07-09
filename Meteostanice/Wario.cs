

namespace Meteostanice
{
    internal class Wario
    {
        public string Degree { get; set; }
        public string Pressure { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Firmware { get; set; }
        public List<Sensor> Input { get; set; }
        public List<Sensor> Output { get; set; }
        public WeatherVariables Variables { get; set; }
        public List<SensorMinMax> MinMax { get; set; }
    }
}
