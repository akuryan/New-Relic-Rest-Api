using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewRelicSharp.Commands;
using NewRelicSharp.Commands.Get;

namespace NewRelicSharp.Tests.Commands.Get
{
    [TestClass]
    public class GetMetricNamesTest : TestCommandsBase
    {
        [TestMethod]
        public void TestGetMetricNames()
        {
            var command = testCommandBuilder.CreateGetMetricNames();

            CheckCommandMethod(command);

            var response = accessor.GetMetricNames();

            Assert.IsNotNull(response, String.Format("Metrics is null"));

        }
    }
}
