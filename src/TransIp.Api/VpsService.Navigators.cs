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
        public async Task<ICollection<Backup>> GetBackupsForVpsAsync(string vpsName)
        {
            SetSignatureCookies("getVpsBackupsByVps", new object[] { vpsName });
            var result = await Client.getVpsBackupsByVpsAsync(vpsName);
            return Mapper.Map<List<Backup>>(result);
        }


        public async Task<ICollection<Snapshot>> GetSnapshotsForVpsAsync(string vpsName)
        {
            SetSignatureCookies("getSnapshotsByVps", new object[] { vpsName });
            var result = await Client.getSnapshotsByVpsAsync(vpsName);
            return Mapper.Map<List<Snapshot>>(result);
        }

    }
}
