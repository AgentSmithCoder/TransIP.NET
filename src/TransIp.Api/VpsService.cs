using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using AutoMapper;
using TransIp.Api.Dto;
using TransIp.Api.Dto.Vps;
using TransIp.Api.Remote;
using AvailabilityZone = TransIp.Api.Dto.Vps.AvailabilityZone;
using OperatingSystem = TransIp.Api.Dto.Vps.OperatingSystem;
using PrivateNetwork = TransIp.Api.Dto.Vps.PrivateNetwork;
using Snapshot = TransIp.Api.Dto.Vps.Snapshot;
using Vps = TransIp.Api.Dto.Vps.Vps;

namespace TransIp.Api
{
    public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return System.Convert.ToDateTime(source);
        }
    }

    public partial class VpsService : ClientBase<Remote.VpsServicePortTypeClient, Remote.VpsServicePortType>, IVpsService
    {
        public VpsService(string login, ClientMode mode, string privateKey) : base("VpsService", "https://api.transip.nl/soap/?service=VpsService", login, mode, privateKey)
        {
        }

        protected override VpsServicePortTypeClient CreateClient(Binding binding, EndpointAddress address)
        {
            return new Remote.VpsServicePortTypeClient(binding, address);
        }

        public async Task<ICollection<AvailabilityZone>> GetAllAvailabilityZonesAsync()
        {
            SetSignatureCookies("getAvailableAvailabilityZones", new object[0]);
            var result = await Client.getAvailableAvailabilityZonesAsync();
            return Mapper.Map<List<AvailabilityZone>>(result);
        }

        public async Task<ICollection<OperatingSystem>> GetAllOperatingSystemsAsync()
        {
            SetSignatureCookies("getOperatingSystems", new object[0]);
            var result = await Client.getOperatingSystemsAsync();
            return Mapper.Map<List<OperatingSystem>>(result);
        }

        public async Task<ICollection<PrivateNetwork>> GetAllPrivateNetworksAsync()
        {
            SetSignatureCookies("getAllPrivateNetworks", new object[0]);
            var result = await Client.getAllPrivateNetworksAsync();
            return Mapper.Map<List<PrivateNetwork>>(result);
        }


        public async Task<ICollection<Vps>> GetVpsListAsync()
        {
            SetSignatureCookies("getVpses", new object[0]);
            var result = await Client.getVpsesAsync();
            return Mapper.Map<List<Vps>>(result);
        }

        public async Task<ICollection<Dto.Vps.Product>> GetAvailableProductsAsync()
        {
            SetSignatureCookies("getAvailableProducts", new object[0]);
            var result = await Client.getAvailableProductsAsync();
            return Mapper.Map<List<Dto.Vps.Product>>(result);
        }

        public async Task<ICollection<Dto.Vps.Product>> GetAvailableAddonsAsync()
        {
            SetSignatureCookies("getAvailableAddons", new object[0]);
            var result = await Client.getAvailableAddonsAsync();
            return Mapper.Map<List<Dto.Vps.Product>>(result);
        }

    }
}