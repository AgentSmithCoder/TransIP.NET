using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransIp.Api;

namespace TransIP.Api.Tests
{
    [TestClass]
    public class OverallVpsQueryTests : TestBase
    {
        [ClassInitialize]
        public static void ClassSetup(TestContext ctx)
        {
            InitTestFixture(ctx);
        }

        [TestMethod]
        public void GetAllPrivateNetworks()
        {
            var svc = CreateVpsService();
            var networks = svc.GetAllPrivateNetworks();
            WriteToConsole(networks);
        }

        [TestMethod]
        public void GetAllOperatingSystems()
        {
            var svc = CreateVpsService();
            var osList = svc.GetAllOperatingSystems();
            WriteToConsole(osList);
        }

        [TestMethod]
        public void GetAllAvailabilityZones()
        {
            var svc = CreateVpsService();
            var availList = svc.GetAllAvailabilityZones();
            WriteToConsole(availList);
        }

        [TestMethod]
        public void ReadVpsServers()
        {
            var svc = CreateVpsService();
            var vpsList = svc.GetVpsList();
            WriteToConsole(vpsList);
        }

        [TestMethod]
        public void GetAllAvailableProducts()
        {
            var svc = CreateVpsService();
            var products = svc.GetAvailableProducts();
            WriteToConsole(products);
        }

        [TestMethod]
        public void GetAllAvailableAddons()
        {
            var svc = CreateVpsService();
            var products = svc.GetAvailableAddons();
            WriteToConsole(products);
        }

    }
}