using System.Collections.Generic;
using TransIp.Api.Dto;
using TransIp.Api.Dto.Vps;

namespace TransIp.Api
{
    public static class VpsServiceSynchronousExtensions
    {
        public static ICollection<OperatingSystem> GetAllOperatingSystems(this IVpsService vpsService)
        {
            return vpsService.GetAllOperatingSystemsAsync().Result;
        }

        public static ICollection<AvailabilityZone> GetAllAvailabilityZones(this IVpsService vpsService)
        {
            return vpsService.GetAllAvailabilityZonesAsync().Result;
        }

        public static ICollection<PrivateNetwork> GetAllPrivateNetworks(this IVpsService vpsService)
        {
            return vpsService.GetAllPrivateNetworksAsync().Result;
        }

        public static ICollection<Product> GetAvailableProducts(this IVpsService service)
        {
            return service.GetAvailableProductsAsync().Result;
        }

        public static ICollection<Product> GetAvailableAddons(this IVpsService service)
        {
            return service.GetAvailableAddonsAsync().Result;
        }

        public static ICollection<Vps> GetVpsList(this IVpsService vpsService)
        {
            return vpsService.GetVpsListAsync().Result;
        }

        public static ICollection<Backup> GetBackupsForVps(this IVpsService vpsService, string vpsName)
        {
            return vpsService.GetBackupsForVpsAsync(vpsName).Result;
        }

        public static ICollection<Snapshot> GetSnapshotsForVps(this IVpsService vpsService, string vpsName)
        {
            return vpsService.GetSnapshotsForVpsAsync(vpsName).Result;
        }

        public static void Start(this IVpsService vpsService, string vpsName)
        {
            vpsService.StartAsync(vpsName).Wait();
        }

        public static void Stop(this IVpsService vpsService, string vpsName)
        {
            vpsService.StopAsync(vpsName).Wait();
        }

        public static void Reset(this IVpsService vpsService, string vpsName)
        {
            vpsService.ResetAsync(vpsName).Wait();
        }

        public static ICollection<Product> GetAvailableUpgradesForVps(this IVpsService service, string vpsName)
        {
            return service.GetAvailableUpgradesForVpsAsync(vpsName).Result;
        }

        public static ICollection<Product> GetAvailableAddonsForVps(this IVpsService service, string vpsName)
        {
            return service.GetAvailableAddonsForVpsAsync(vpsName).Result;
        }
    }
}