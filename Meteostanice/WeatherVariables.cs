

using System.Xml.Serialization;

namespace Meteostanice
{
    public class WeatherVariables
    {
        [XmlElement("sunrise")]
        public string Sunrise { get; set; } = string.Empty;

        [XmlElement("sunset")]
        public string Sunset { get; set; } = string.Empty;

        [XmlElement("civstart")]
        public string Civstart { get; set; } = string.Empty;

        [XmlElement("civend")]
        public string Civend { get; set; } = string.Empty;

        [XmlElement("nautstart")]
        public string Nautstart { get; set; } = string.Empty;

        [XmlElement("nautend")]
        public string Nautend { get; set; } = string.Empty;

        [XmlElement("astrostart")]
        public string Astrostart { get; set; } = string.Empty;

        [XmlElement("astroend")]
        public string Astroend { get; set; } = string.Empty;

        [XmlElement("daylen")]
        public string Daylen { get; set; } = string.Empty;

        [XmlElement("civlen")]
        public string Civlen { get; set; } = string.Empty;

        [XmlElement("nautlen")]
        public string Nautlen { get; set; } = string.Empty;
        
        [XmlElement("astrolen")]
        public string Astrolen { get; set; } = string.Empty;

        [XmlElement("moonphase")]
        public int Moonphase { get; set; }

        [XmlElement("isday")]
        public int IsDay { get; set; }

        [XmlElement("bio")]
        public int Bio { get; set; }

        [XmlElement("pressure_old")]
        public double PressureOld { get; set; }

        [XmlElement("temperature_avg")]
        public double TemperatureAvg { get; set; }

        [XmlElement("agl")]
        public int Agl { get; set; }

        [XmlElement("fog")]
        public int Fog { get; set; }

        [XmlElement("lsp")]
        public int Lsp { get; set; }
    }
}
