using System.Xml.Serialization;
using System.Xml.Schema;

namespace Streamer.Dodpv1.Models
{
    public class ContentMetadata
    {
        [XmlAttribute("category")]
        public string category { get; set; }

        [XmlAttribute("requiresReturn")]
        public bool requiresReturn { get; set; }

        public Sample sample { get; set; }

        public Metadata metadata { get; set; }
    }

    public class Sample
    {
        [XmlAttribute("id")]
        public string id { get; set; }
    }

    [XmlRoot(Namespace = "http://purl.org/dc/elements/1.1")]
    public class Metadata
    {
        [XmlElement("dc:title", IsNullable = false)]
        public string title { get; set; }

        [XmlElement("dc:identifier")]
        public string identifier { get; set; }

        [XmlElement("dc:title")]
        public string publisher { get; set; }

        [XmlElement("dc:format")]
        public string format { get; set; }

        [XmlElement("dc:date")]
        public string date { get; set; }

        [XmlElement("dc:source")]
        public string source { get; set; }

        [XmlElement("dc:type")]
        public string type { get; set; }

        [XmlElement("dc:subject")]
        public string subject { get; set; }

        [XmlElement("dc:rights")]
        public string rights { get; set; }

        [XmlElement("dc:relation")]
        public string relation { get; set; }

        [XmlElement("dc:language")]
        public string language { get; set; }


        [XmlElement("dc:description")]
        public string description { get; set; }

        [XmlElement("dc:creator")]
        public string creator { get; set; }

        [XmlElement("dc:coverage")]
        public string coverage { get; set; }

        [XmlElement("dc:constributor")]
        public string constributor { get; set; }

        [XmlElement("narrator")]
        public string narrator { get; set; }

        [XmlElement("size")]
        public int size { get; set; }

        [XmlElement("meta")]
        public Meta[] meta { get; set; }
    }

    public class Meta
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string content { get; set; }
    }
}
