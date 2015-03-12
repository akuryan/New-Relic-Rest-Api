using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelicSharp.Constants;

namespace NewRelicSharp.Commands.Get
{
    public class GetApplicationIds : GetCommandBase
    {
        public override string GetQuery()
        {
            return RestApiConstants.ApiRootV2 + RestApiConstants.Applications + "." + RestApiConstants.DataFormatXML;
        }
    }
}
