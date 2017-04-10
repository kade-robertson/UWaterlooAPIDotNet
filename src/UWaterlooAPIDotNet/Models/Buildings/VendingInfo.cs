using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class VendingInfo 
    {
        /// <summary>
        /// A description of the location of the vending machine(s).
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// The number of vending machines in the particular location.
        /// </summary>
        [JsonProperty(PropertyName = "machines")]
        public int? Machines { get; private set; }

        /// <summary>
        /// The <see cref="List{T}"/> of products available from the vending machines.
        /// </summary>
        [JsonProperty(PropertyName = "products")]
        public List<string> Products { get; private set; }
    }
}
