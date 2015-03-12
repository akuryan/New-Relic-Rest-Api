using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelicSharp.Commands;

namespace NewRelicSharp.Tests.Commands
{
    public class MockApiCommandBuilder : IApiCommandBuilder
    {
        private readonly NewRelicConfiguration config;

        public MockApiCommandBuilder(NewRelicConfiguration config)
        {
            this.config = config;
        }

        public IApiCommand CreateGetMetricNames()
        {
            throw new NotImplementedException();
        }

        public IApiCommand CreateGetApplicationIds()
        {
            throw new NotImplementedException();
        }
    }
}
