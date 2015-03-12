using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "field")]
    public class MetricField
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}
