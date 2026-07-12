

using System.Xml.Serialization;

namespace Meteostanice
{

    [XmlRoot("wario")]
    public class Wario
    {
        [XmlAttribute("degree")]
        public string Degree { get; set; } = string.Empty;

        [XmlAttribute("pressure")]
        public string Pressure { get; set; } = string.Empty;

        [XmlAttribute("serial_number")]
        public string SerialNumber { get; set; } = string.Empty;

        [XmlAttribute("model")]
        public string Model { get; set; } = string.Empty;

        [XmlAttribute("firmware")]
        public string Firmware { get; set; } = string.Empty;

        [XmlArray("input")]
        [XmlArrayItem("sensor")]
        public List<Sensor> Input { get; set; } = new();

        [XmlArray("output")]
        [XmlArrayItem("sensor")]
        public List<Sensor> Output { get; set; } = new();

        [XmlElement("variable")]
        public WeatherVariables Variables { get; set; } = new();

        [XmlArray("minmax")]
        [XmlArrayItem("s")]
        public List<SensorMinMax> MinMax { get; set; } = new();
    }
}
