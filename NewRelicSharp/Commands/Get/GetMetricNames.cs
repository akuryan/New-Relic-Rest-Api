using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelicSharp.Constants;

namespace NewRelicSharp.Commands.Get
{
    public class GetMetricNames : GetCommandBase
    {
        public string AppId { get; set; }

        public override string GetQuery()
        {
            return RestApiConstants.ApiRootV1 + RestApiConstants.Applications + "/" + AppId + "/" + RestApiConstants.Metrics + "." + RestApiConstants.DataFormatXML;
        }
    }
}
