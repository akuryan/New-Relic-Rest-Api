using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewRelicSharp.Tests.Commands.Get
{
    [TestClass]
    public class GetApplicationIdsTest : TestCommandsBase
    {
        [TestMethod]
        public void TestGetApplicationIds()
        {
            var command = testCommandBuilder.CreateGetApplicationIds();

            CheckCommandMethod(command);

            var response = accessor.GetApplicationIds();

            Assert.IsNotNull(response, String.Format("ApplicationIds is null"));

        }
    }
}
