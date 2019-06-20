using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransIp.Api;

namespace TransIP.Api.Tests
{
    [TestClass]
    public class VpsOperationTests : TestBase
    {
        /*
         * Be careful when running these tests. These operations are performed on the test VPS.
         * Some 'tests' are depended on state.
         *
         * For security reason, I;ve commented out the TestMethod attributes.
         */


        [ClassInitialize]
        public static void ClassSetup(TestContext ctx)
        {
            InitTestFixture(ctx);
        }

        //[TestMethod]
        public void StartVps()
        {
            var svc = CreateVpsService();
            svc.Start(config.TestVps);
        }

        //[TestMethod]
        public void StopVps()
        {
            var svc = CreateVpsService();
            svc.Stop(config.TestVps);
        }

        //[TestMethod]
        public void ResetVps()
        {
            var svc = CreateVpsService();
            svc.Reset(config.TestVps);
        }

    }
}