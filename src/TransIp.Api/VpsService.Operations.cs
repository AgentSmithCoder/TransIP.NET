using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TransIp.Api.Dto.Vps;

namespace TransIp.Api
{
    public partial class VpsService
    {
        public async Task StartAsync(string vpsName)
        {
            SetSignatureCookies("start", new object[] { vpsName });
            await Client.startAsync(vpsName);
        }

        public async Task StopAsync(string vpsName)
        {
            SetSignatureCookies("stop", new object[] { vpsName });
            await Client.stopAsync(vpsName);
        }

        public async Task ResetAsync(string vpsName)
        {
            SetSignatureCookies("reset", new object[] { vpsName });
            await Client.resetAsync(vpsName);
        }

        public async Task<ICollection<Product>> GetAvailableUpgradesForVpsAsync(string vpsName)
        {
            SetSignatureCookies("getAvailableUpgrades", new object[] { vpsName });
            var upgrades = await Client.getAvailableUpgradesAsync(vpsName);
            return Mapper.Map<ICollection<Product>>(upgrades);
        }

        public async Task<ICollection<Product>> GetAvailableAddonsForVpsAsync(string vpsName)
        {
            SetSignatureCookies("getAvailableAddonsForVps", new object[] { vpsName });
            var addons = await Client.getAvailableAddonsForVpsAsync(vpsName);
            return Mapper.Map<ICollection<Product>>(addons);
        }

    }
}
