using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "links")]
    public class ApplicationResponseLinks
    {
        [XmlElement(ElementName = "application.servers")]
        public string ApplicationServers { get; set; }

        [XmlElement(ElementName = "application.server")]
        public string ApplicationServer { get; set; }

        [XmlElement(ElementName = "application.application_hosts")]
        public string ApplicationHosts { get; set; }

        [XmlElement(ElementName = "application.application_host")]
        public string ApplicationHost { get; set; }

        [XmlElement(ElementName = "application.application_instances")]
        public string ApplicationInstances { get; set; }

        [XmlElement(ElementName = "application.application_instance")]
        public string ApplicationInstance { get; set; }

        [XmlElement(ElementName = "application.alert_policy")]
        public string ApplicationAlertPolicy { get; set; }

    }
}
