using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Resources
{
    public class GooseData
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; private set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "updated")]
        private string LastUpdatedString { get; set; }

        [JsonIgnore]
        public ZonedDateTime LastUpdated {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(LastUpdatedString));
                var o = DateTimeOffset.Parse(LastUpdatedString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }
    }
}
