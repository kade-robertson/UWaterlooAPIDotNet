using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Building
{
    public class Building 
    {
        [JsonProperty(PropertyName = "building_id")]
        public string ID { get; private set; }

        [JsonProperty(PropertyName = "building_code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "building_name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "alternate_names")]
        public List<string> AlternateNames { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; private set; }

        [JsonProperty(PropertyName = "building_sections")]
        public List<BuildingSection> Sections { get; private set; }
    }
}
