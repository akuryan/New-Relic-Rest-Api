using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "application_instances")]
    public class ApplicationInstances
    {
        [XmlElement(ElementName = "application_instance")]
        public List<int> ApplicationInstance { get; set; }
    }
}
