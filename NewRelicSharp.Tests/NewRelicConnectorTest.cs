using System;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewRelicSharp.Commands.Get;
using NewRelicSharp.Constants;
using NewRelicSharp.Items;

namespace NewRelicSharp.Tests
{
    [TestClass]
    public class NewRelicConnectorTest
    {
        [TestMethod]
        public void TestNewRelicConnector()
        {
            var config = new NewRelicConfiguration
            {
                ApiKey = "4bc93f3d8f593d3fa18a31d46bb908e449b1e330"
            };

            var connector = new NewRelicConnector(config);

            var command = new GetMetricNames()
            {
                AppId = "4607029"
            };


//            var item = new DeploymentsApplicationName()
//            {
//                App_Name = "NewRelicDotNetAgentAPIDemo",
//                User = "Unit test user",
//                Description = "Test description",
//                Changelog = "Test change log",
//                Environment = "Test environment",
//                Revision = "Test revision"
//                
//            };

            var answer = connector.GetData(RestApiConstants.NewRelicHttpsUrl + "api/v1/" + command.GetQuery());

            //var answer = connector.PostData(RestApiConstants.NewRelicHttpsUrl + RestApiConstants.DeploymentsUri, item.ToString());

            Assert.IsTrue(answer.IsSuccessStatusCode, "Wrong status code: " + answer.ReasonPhrase);

        }
    }
}
