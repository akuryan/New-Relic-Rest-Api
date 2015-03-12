using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "metrics")]
    public class Metrics
    {
        [XmlElement(ElementName = "metric")]
        public List<Metric> MetricList { get; set; }
    }
}
