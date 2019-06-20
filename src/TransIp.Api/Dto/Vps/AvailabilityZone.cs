using System.Runtime.Serialization;

namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models an Availability Zone
    /// </summary>
    public class AvailabilityZone
    {
        /// <summary>
        /// The name of the Availability Zone
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The country the Availability Zone is in
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// If this is true, this zone will be used as the default zone for vps orders and clones
        /// </summary>
        public bool IsDefault { get; set; }

        #region Overrides of Object

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}