

using System.Xml.Serialization;

namespace Meteostanice
{
    public class Sensor
    {
        [XmlElement("type")]
        public string Type { get; set; } = string.Empty;

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement("place")]
        public string Place { get; set; } = string.Empty;

        [XmlElement("value")]
        public string Value { get; set; } = string.Empty;

    }
}
