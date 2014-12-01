namespace NewRelicSharp.Tests.Items
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NewRelicSharp.Items;

    [TestClass]
    public class DeploymentsClassTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ApplicationIdExceptionTest()
        {
            var deployment = new DeploymentsApplicationId
            {
                AppName = TestData.DeploymentsBase.AppNameString, 
                Changelog = TestData.DeploymentsBase.ChangeLogString, 
                Description = TestData.DeploymentsBase.DescriptionString, 
                Environment = TestData.DeploymentsBase.EnvironmentString, 
                Revision = TestData.DeploymentsBase.RevisionString, 
                User = TestData.DeploymentsBase.UserString
            };

            deployment.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AppNameExceptionTest()
        {
            var deployment = new DeploymentsApplicationName
            {
                AppName = TestData.DeploymentsBase.AppNameString,
                Changelog = TestData.DeploymentsBase.ChangeLogString,
                Description = TestData.DeploymentsBase.DescriptionString,
                Environment = TestData.DeploymentsBase.EnvironmentString,
                Revision = TestData.DeploymentsBase.RevisionString,
                User = TestData.DeploymentsBase.UserString
            };

            deployment.ToString();
        }
    }
}
