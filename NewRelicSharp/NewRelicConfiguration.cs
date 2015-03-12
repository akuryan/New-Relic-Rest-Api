using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class NewRelicConfiguration
    {
        /// <summary>
        /// Api key to be added to "x-api-key" header
        /// </summary>
        public string ApiKey {get; set; }

        public string AgentId { get; set; }

        public string AppId { get; set; }

        public string ApplicationName { get; set; }
    }
}
