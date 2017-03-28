using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class PointOfInterest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; private set; }
    }
}
