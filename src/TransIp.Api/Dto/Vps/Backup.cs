using System;

namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models a vps backup
    /// </summary>
    public class Backup
    {
        /// <summary>
        /// This class models a vps backup
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The backup creation date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The backup disk size (in bytes)
        /// </summary>
        public int DiskSize { get; set; }

        /// <summary>
        /// The backup operatingSystem
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// The name of the availability zone the backup is in
        /// </summary>
        public string AvailabilityZone { get; set; }
    }
}