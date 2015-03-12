using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "application_hosts")]
    public class ApplicationHosts
    {
        [XmlElement(ElementName = "application_host")]
        public List<int> Hosts { get; set; } 
    }
}
