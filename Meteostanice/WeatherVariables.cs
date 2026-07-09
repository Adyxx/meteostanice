

using System.Xml.Serialization;

namespace Meteostanice
{
    public class WeatherVariables
    {
        [XmlElement("sunrise")]
        public string Sunrise { get; set; }

        [XmlElement("sunset")]
        public string Sunset { get; set; }

        [XmlElement("civstart")]
        public string Civstart { get; set; }

        [XmlElement("civend")]
        public string Civend { get; set; }

        [XmlElement("nautstart")]
        public string Nautstart { get; set; }

        [XmlElement("nautend")]
        public string Nautend { get; set; }

        [XmlElement("astrostart")]
        public string Astrostart { get; set; }

        [XmlElement("astroend")]
        public string Astroend { get; set; }

        [XmlElement("daylen")]
        public string Daylen { get; set; }

        [XmlElement("civlen")]
        public string Civlen { get; set; }

        [XmlElement("nautlen")]
        public string Nautlen { get; set; }
        
        [XmlElement("astrolen")]
        public string Astrolen { get; set; }

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
