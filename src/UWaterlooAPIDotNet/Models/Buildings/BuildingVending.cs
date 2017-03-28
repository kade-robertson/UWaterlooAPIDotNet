using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingVending
    {
        [JsonProperty(PropertyName = "building_name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "building_acronym")]
        public string Code { get; private set; }
        
        [JsonProperty(PropertyName = "vending_machines")]
        public List<VendingInfo> VendingMachines { get; private set; }
    }
}
