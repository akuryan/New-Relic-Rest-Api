using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewRelicSharp.Items
{
    [XmlRoot(ElementName = "settings")]
    public class ApplicationSettings
    {
        [XmlElement(ElementName = "app_apdex_threshold")]
        public float AppApdexThreshold { get; set; }

        [XmlElement(ElementName = "end_user_apdex_threshold")]
        public float EndUserApdexThreshold { get; set; }

        [XmlElement(ElementName = "enable_real_user_monitoring")]
        public bool EnableRealUserMonitoring { get; set; }

        [XmlElement(ElementName = "use_server_side_config")]
        public bool UseServerSideConfig { get; set; }

    }
}
