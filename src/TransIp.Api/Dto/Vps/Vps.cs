namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models a Vps
    /// </summary>
    public class Vps
    {

        /// <summary>
        /// The Vps name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Vps description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Vps OperatingSystem
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// The Vps disk size (in bytes)
        /// </summary>
        public int DiskSize { get; set; }

        /// <summary>
        /// The Vps memory size (in bytes)
        /// </summary>
        public int MemorySize { get; set; }

        /// <summary>
        /// The Vps cpu count
        /// </summary>
        public int Cpus { get; set; }

        /// <summary>
        /// The Vps status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The Vps main ipAddress
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// The Vps main ipv6 address
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// The Vps MacAddress
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// If the vps is blocked
        /// </summary>
        public bool IsBlocked { get; set; }

        /// <summary>
        /// If this vps is customer locked
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// The availability zone the vps is in
        /// </summary>
        public string AvailabilityZone { get; set; }


        #region Overrides of Object

        public override string ToString()
        {
            return $"{Description} ({Name})";
        }

        #endregion
    }
}