using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Resources
{
    public class InfosessionBuilding
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "room")]
        public string Room { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "map_url")]
        public Uri MapURL { get; private set; }
    }
}
