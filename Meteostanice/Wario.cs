

using System.Xml.Serialization;

namespace Meteostanice
{

    [XmlRoot("wario")]
    public class Wario
    {
        [XmlAttribute("degree")]
        public string Degree { get; set; }

        [XmlAttribute("pressure")]
        public string Pressure { get; set; }

        [XmlAttribute("serial_number")]
        public string SerialNumber { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("firmware")]
        public string Firmware { get; set; }

        [XmlArray("input")]
        [XmlArrayItem("sensor")]
        public List<Sensor> Input { get; set; }

        [XmlArray("output")]
        [XmlArrayItem("sensor")]
        public List<Sensor> Output { get; set; }

        [XmlElement("variable")]
        public WeatherVariables Variables { get; set; }

        [XmlArray("minmax")]
        [XmlArrayItem("s")]
        public List<SensorMinMax> MinMax { get; set; }
    }
}
