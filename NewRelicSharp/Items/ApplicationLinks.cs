using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "links")]
    public class ApplicationLinks
    {
        [XmlElement(ElementName = "application_instances")]
        public ApplicationInstances Instances { get; set; }

        [XmlElement(ElementName = "alert_policy")]
        public string AlertPolicy { get; set; }

        [XmlElement(ElementName = "servers")]
        public ApplicationServers Servers { get; set; }

        [XmlElement(ElementName = "application_hosts")]
        public ApplicationHosts Hosts { get; set; }
    }
}
