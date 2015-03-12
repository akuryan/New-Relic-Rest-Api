using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "application_summary")]
    public class ApplicationSummary
    {
        [XmlElement(ElementName = "response_time")]
        public float ResponseTime { get; set; }

        [XmlElement(ElementName = "throughput")]
        public float Throughput { get; set; }

        [XmlElement(ElementName = "error_rate")]
        public float ErrorRate { get; set; }

        [XmlElement(ElementName = "apdex_target")]
        public float ApdexTarget { get; set; }

        [XmlElement(ElementName = "apdex_score")]
        public float ApdexScore { get; set; }

        [XmlElement(ElementName = "host_count")]
        public int HostCount { get; set; }

        [XmlElement(ElementName = "instance_count")]
        public int InstanceCount { get; set; }
    }
}
