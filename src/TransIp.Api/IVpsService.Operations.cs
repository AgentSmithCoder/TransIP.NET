using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TransIp.Api.Dto.Vps;

namespace TransIp.Api
{
    public partial interface IVpsService
    {
        /// <summary>
        /// Start a Vps
        /// </summary>
        /// <param name="vpsName">The vps name</param>
        Task StartAsync(string vpsName);

        /// <summary>
        /// Stop a Vps
        /// </summary>
        /// <param name="vpsName"></param>
        Task StopAsync(string vpsName);

        /// <summary>
        /// Reset a Vps
        /// </summary>
        /// <param name="vpsName"></param>
        Task ResetAsync(string vpsName);

        /// <summary>
        /// Get available VPS upgrades for a specific Vps
        /// </summary>
        /// <param name="vpsName">The name of the VPS</param>
        /// <returns>List of available VPS Products</returns>
        Task<ICollection<Product>> GetAvailableUpgradesForVpsAsync(string vpsName);

        /// <summary>
        /// Get available Addons for Vps
        /// </summary>
        /// <param name="vpsName">The name of the VPS</param>
        /// <returns>List of available VPS addons</returns>
        Task<ICollection<Product>> GetAvailableAddonsForVpsAsync(string vpsName);
    }
}
