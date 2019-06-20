using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TransIP.Api.Tests
{
    public class TestConfiguration
    {
        public const string TestConfigurationFilename = @"c:\temp\transip-api-config.json";
        public const string BaseInstallVpsName = "BaseInstallVps";
        public const string TestVpsName = "TestVps";
        private static string privateKey = null;

        public Dictionary<string, string> Servers { get; set; } = new Dictionary<string, string>();

        public string Username { get; set; }
        public string PrivateKeyFile { get; set; }

        public string BaseInstallVps => GetVpsName(BaseInstallVpsName);
        public string TestVps => GetVpsName(TestVpsName);

        public string PrivateKey
        {
            get
            {
                if (privateKey == null)
                {
                    if (!File.Exists(PrivateKeyFile))
                        throw new FileNotFoundException($"File '{PrivateKeyFile}' not found. Please make sure that PrivateKeyFile points to a PEM serialized private key!");

                    privateKey = File.ReadAllText(PrivateKeyFile);
                }

                return privateKey;
            }
        }

        private string GetVpsName(string name)
        {
            if (Servers.TryGetValue(name, out string vpsName)) return vpsName;
            throw new InvalidOperationException($"Unit Test configuration is missing a 'Servers' entry for '{name}' ");
        }

        public static TestConfiguration Load()
        {
            if (!File.Exists(TestConfigurationFilename))
                throw new FileNotFoundException($"'{TestConfigurationFilename}' file not found. Please readme the project Readme.txt file for information about this file layout.");

            var json = File.ReadAllText(TestConfigurationFilename);
            return JsonConvert.DeserializeObject<TestConfiguration>(json);
        }
    }
}