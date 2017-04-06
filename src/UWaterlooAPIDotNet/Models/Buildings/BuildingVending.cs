using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingVending
    {
        /// <summary>
        /// The name of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_name")]
        public string Name { get; private set; }

        /// <summary>
        /// The code for the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_acronym")]
        public string Code { get; private set; }
        
        /// <summary>
        /// A list of the available vending machines in the building.
        /// </summary>
        [JsonProperty(PropertyName = "vending_machines")]
        public List<VendingInfo> VendingMachines { get; private set; }
    }
}
