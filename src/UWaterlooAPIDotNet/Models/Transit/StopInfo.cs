using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Transit
{
    public class StopInfo 
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "parent")]
        public string Parent { get; private set; }

        [JsonProperty(PropertyName = "zone_id")]
        public string ZoneID { get; private set; }

        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; private set; }
    }
}
