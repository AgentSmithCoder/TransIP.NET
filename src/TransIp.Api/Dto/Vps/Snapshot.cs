using System;

namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models a vps snapshot
    /// </summary>
    public class Snapshot
    {
        /// <summary>
        /// The snapshot name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The snapshot description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The snapshot creation date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The name of the availability zone the snapshot is in
        /// </summary>
        public string AvailabilityZone { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Description}";
        }

    }
}