using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSharp.Commands
{
    public interface IApiCommandBuilder
    {
        IApiCommand CreateGetMetricNames();
        IApiCommand CreateGetApplicationIds();
    }
}
