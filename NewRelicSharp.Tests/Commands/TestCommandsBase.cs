using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewRelicSharp.Commands;

namespace NewRelicSharp.Tests.Commands
{
    public class TestCommandsBase
    {
        protected readonly NewRelicAccessor accessor;
//        protected readonly IApiCommandBuilder mockCommandBuilder;
        protected readonly IApiCommandBuilder testCommandBuilder;

        public TestCommandsBase()
        {
//            var mockConfig = new NewRelicConfiguration()
//            {
//                AgentId = "AgentID111",
//                ApiKey = "ApiKey111"
//            };

            var config = new NewRelicConfiguration()
            {
                AppId = "2430784",
                ApiKey = "6629fcbc729fffcde32ed9b61619ab8b7fdaaf5a9b1e330"
            };

//            this.mockCommandBuilder = new MockApiCommandBuilder(mockConfig);
            this.testCommandBuilder = new ApiCommandBuilder(config);

            this.accessor = new NewRelicAccessor(config, this.testCommandBuilder);

        }

        protected void CheckCommandMethod(IApiCommand command)
        {
            Assert.AreEqual("GET", command.Method.Method, String.Format("Wrong method '{0}'", command.Method));
        }
    }
}
