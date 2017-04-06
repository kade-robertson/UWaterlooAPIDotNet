using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class Building 
    {
        /// <summary>
        /// The ID of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_id")]
        public string ID { get; private set; }

        /// <summary>
        /// The code of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_code")]
        public string Code { get; private set; }

        /// <summary>
        /// The full name of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_name")]
        public string Name { get; private set; }

        /// <summary>
        /// A list of alternative names which refer to this building.
        /// </summary>
        [JsonProperty(PropertyName = "alternate_names")]
        public List<string> AlternateNames { get; private set; }

        /// <summary>
        /// The latitude of the building in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        /// <summary>
        /// The longitude of the building in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        /// <summary>
        /// A list of sections of the building, if available.
        /// </summary>
        [JsonProperty(PropertyName = "building_sections")]
        public List<BuildingSection> Sections { get; private set; }

        /// <summary>
        /// The ID of the YouTube video of the building, if available.
        /// </summary>
        [JsonProperty(PropertyName = "youtube_vid")]
        public string YouTubeID { get; private set; }

        /// <summary>
        /// The ID of the Streamable video of the building, if available.
        /// </summary>
        [JsonProperty(PropertyName = "streamable_vid")]
        public string StreamableID { get; private set; }

        /// <summary>
        /// A URL which leads directly to the YouTube video, if available.
        /// </summary>
        [JsonIgnore]
        public Uri YouTubeURL {
            get {
                return new Uri($"https://www.youtube.com/watch?v={YouTubeID}");
            }
        }

        /// <summary>
        /// A URL which leads directly to the Streamable video, if available.
        /// </summary>
        [JsonIgnore]
        public Uri StreamableURL {
            get {
                return new Uri($"https://streamable.com/{StreamableID}");
            }
        }
    }
}
