using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class VendingInfo 
    {
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        [JsonProperty(PropertyName = "machines")]
        public int? Machines { get; private set; }

        [JsonProperty(PropertyName = "products")]
        public List<string> Products { get; private set; }
    }
}
