using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "application")]
    public class Application
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "health_status")]
        public string HealthStatus { get; set; }

        [XmlElement(ElementName = "reporting")]
        public bool Reporting { get; set; }

        [XmlElement(ElementName = "last_reported_at")]
        public string LastReportedAt { get; set; }

        [XmlElement(ElementName = "application_summary")]
        public ApplicationSummary ApplicationSummary { get; set; }

        [XmlElement(ElementName = "settings")]
        public ApplicationSettings Settings { get; set; }

        [XmlElement(ElementName = "links")]
        public ApplicationLinks Links { get; set; }

    }
}
