using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "fields")]
    public class MetricFields
    {
        [XmlElement(ElementName = "field")]
        public List<MetricField> Fields { get; set; } 
    }
}
