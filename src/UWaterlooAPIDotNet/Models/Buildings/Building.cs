using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
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
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "building_sections")]
        public List<BuildingSection> Sections { get; private set; }

        [JsonProperty(PropertyName = "youtube_vid")]
        public string YouTubeID { get; private set; }

        [JsonProperty(PropertyName = "streamable_vid")]
        public string StreamableID { get; private set; }

        [JsonIgnore]
        public Uri YouTubeURL {
            get {
                return new Uri($"https://www.youtube.com/watch?v={YouTubeID}");
            }
        }

        [JsonIgnore]
        public Uri StreamableURL {
            get {
                return new Uri($"https://streamable.com/{StreamableID}");
            }
        }
    }
}
