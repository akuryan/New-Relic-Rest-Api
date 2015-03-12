using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "servers")]
    public class ApplicationServers
    {
        [XmlElement(ElementName = "server")]
        public List<int> Servers { get; set; }
    }
}
