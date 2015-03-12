using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelicSharp.Commands.Get;

namespace NewRelicSharp.Commands
{
    public class ApiCommandBuilder : IApiCommandBuilder
    {
        private readonly NewRelicConfiguration config;

        public ApiCommandBuilder(NewRelicConfiguration config)
        {
            this.config = config;    
        }

        public IApiCommand CreateGetMetricNames()
        {
            var command = new GetMetricNames()
            {
                AppId = config.AppId
            };

            return command;
        }

        public IApiCommand CreateGetApplicationIds()
        {
            var command = new GetApplicationIds()
            {

            };

            return command;
        }
    }
}
