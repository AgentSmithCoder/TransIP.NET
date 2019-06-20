using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransIp.Api.Dto;
using TransIp.Api.Dto.Vps;

namespace TransIp.Api
{
    public partial interface IVpsService
    {
        /// <summary>
        /// Get all operating systems
        /// </summary>
        /// <returns>List of Operating Systems</returns>
        Task<ICollection<OperatingSystem>> GetAllOperatingSystemsAsync();

        /// <summary>
        /// Get all availability zones
        /// </summary>
        /// <returns>Returns an list of available AvailabilityZones</returns>
        Task<ICollection<AvailabilityZone>> GetAllAvailabilityZonesAsync();

        /// <summary>
        /// Get all Vpses
        /// </summary>
        /// <returns><returns> an list of Vps objects</returns>/returns>
        Task<ICollection<Vps>> GetVpsListAsync();

        /// <summary>
        /// Get all Private networks in your account
        /// </summary>
        /// <returns>List of Private networks</returns>
        Task<ICollection<PrivateNetwork>> GetAllPrivateNetworksAsync();

        /// <summary>
        /// Get available VPS products
        /// </summary>
        /// <returns>List of available VPS Products</returns>
        Task<ICollection<Product>> GetAvailableProductsAsync();

        /// <summary>
        /// Get available VPS addons
        /// </summary>
        /// <returns>List of available VPS Products</returns>
        Task<ICollection<Product>> GetAvailableAddonsAsync();

    }
}