using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingSection
    {
        /// <summary>
        /// The name of the particular building section.
        /// </summary>
        [JsonProperty(PropertyName = "section_name")]
        public string Name { get; private set; }

        /// <summary>
        /// The latitude of the particular section in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        /// <summary>
        /// The longitude of the particular section in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }
    }
}
