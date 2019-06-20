using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TransIp.Api;

namespace TransIP.Api.Tests
{
    public abstract class TestBase
    {
        protected static TestConfiguration config;
        private static IVpsService vpsService;
        private static IDomainService domainService;

        private static readonly JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        };


        public static void InitTestFixture(TestContext ctx)
        {
            if (config == null)
                config = TestConfiguration.Load();
        }


        protected IVpsService CreateVpsService()
        {
            if (vpsService == null)
            {
                vpsService = new VpsService(config.Username, ClientMode.ReadWrite, config.PrivateKey);
            }

            return vpsService;
        }

        protected IDomainService CreateDomainService()
        {
            if (domainService == null)
            {
                domainService = new DomainService(config.Username, ClientMode.ReadWrite, config.PrivateKey);
            }

            return domainService;

        }

        protected void WriteToConsole(object data)
        {
            Console.WriteLine(JsonConvert.SerializeObject(data, jsonSettings));
        }
    }
}