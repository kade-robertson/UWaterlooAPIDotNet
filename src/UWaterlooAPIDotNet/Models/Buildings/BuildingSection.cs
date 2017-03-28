using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingSection
    {
        [JsonProperty(PropertyName = "section_name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }
    }
}
