using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "applications")]
    public class Applications
    {
        [XmlElement(ElementName = "application")]
        public List<Application> applications;
    }
}
