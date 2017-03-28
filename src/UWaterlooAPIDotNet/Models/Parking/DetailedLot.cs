using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Parking
{
    public class DetailedLot
    {
        [JsonProperty(PropertyName = "lot_name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; private set; }

        [JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; private set; }

        [JsonProperty(PropertyName = "current_count")]
        public int CurrentCount { get; private set; }

        [JsonProperty(PropertyName = "percent_filled")]
        public int PercentFilled { get; private set; }

        [JsonProperty(PropertyName = "last_updated")]
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
