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
        /// Get all Backups for a vps
        /// </summary>
        /// <param name="vpsName">The name of the VPS</param>
        /// <returns>List of Backups for VPS</returns>
        Task<ICollection<Backup>> GetBackupsForVpsAsync(string vpsName);

        /// <summary>
        /// Get all snapshots for a vps
        /// </summary>
        /// <param name="vpsName">The name of the VPS</param>
        /// <returns>List of snapshots for VPS</returns>
        Task<ICollection<Snapshot>> GetSnapshotsForVpsAsync(string vpsName);

    }
}
