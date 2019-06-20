using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransIp.Api;

namespace TransIP.Api.Tests
{
    [TestClass]
    public class BasicVpsManagement : TestBase
    {
        [ClassInitialize]
        public static void ClassSetup(TestContext ctx)
        {
            InitTestFixture(ctx);
        }


        [TestMethod]
        public void ReadBackupsForVps()
        {
            var svc = CreateVpsService();
            var backupList = svc.GetBackupsForVps(config.BaseInstallVps);
            WriteToConsole(backupList);
        }

        [TestMethod]
        public void ReadSnapshotsForVps()
        {
            var svc = CreateVpsService();
            var snapshots = svc.GetSnapshotsForVps(config.BaseInstallVps);
            WriteToConsole(snapshots);
        }

        [TestMethod]
        public void GetUpgradesForVps()
        {
            var svc = CreateVpsService();
            var upgrades = svc.GetAvailableUpgradesForVps(config.BaseInstallVps);
            WriteToConsole(upgrades);

        }

        [TestMethod]
        public void GetAddonsForVps()
        {
            var svc = CreateVpsService();
            var upgrades = svc.GetAvailableAddonsForVps(config.BaseInstallVps);
            WriteToConsole(upgrades);
        }

    }
}
