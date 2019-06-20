using System.Runtime.Serialization;

namespace TransIp.Api.Dto.Vps
{
    /// <summary>
    /// This class models a Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Price in euros.
        /// </summary>
        public float Price { get; set; }
        
        /// <summary>
        /// Price for renewing the product in euros.
        /// </summary>
        public float RenewalPrice { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Description}";
        }

    }
}