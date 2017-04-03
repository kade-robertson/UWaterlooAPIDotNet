using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericNews 
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "published")]
        private string DatePublishedString { get; set; }

        [JsonIgnore]
        public ZonedDateTime DatePublished {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(DatePublishedString));
                var o = DateTimeOffset.Parse(DatePublishedString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

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

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }
    }
}
