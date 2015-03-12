using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "applications_response")]
    public class ApplicationsResponse
    {
        [XmlElement(ElementName = "applications")]
        public Applications Applications { get; set; }

        [XmlElement(ElementName = "links")]
        public ApplicationResponseLinks Links { get; set; }
    }
}
