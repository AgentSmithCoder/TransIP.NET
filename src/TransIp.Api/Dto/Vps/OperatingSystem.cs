using System.Runtime.Serialization;

namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models an Operating System
    /// </summary>
    public class OperatingSystem
    {
        /// <summary>
        /// This class models an Operating System
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The snapshot creation date
        /// </summary>
        public DateTimeFormat Created { get; set; }

        /// <summary>
        /// Is a preinstallable image
        /// </summary>
        public bool IsPreInstallableImage { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Description}";
        }

    }
}