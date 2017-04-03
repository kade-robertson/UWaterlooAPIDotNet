using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedEvent
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        [JsonProperty(PropertyName = "start")]
        private string StartTimeString { get; set; }

        [JsonIgnore]
        public ZonedDateTime StartTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(StartTimeString));
                var o = DateTimeOffset.Parse(StartTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "end")]
        private string EndTimeString { get; set; }

        [JsonIgnore]
        public ZonedDateTime EndTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(EndTimeString));
                var o = DateTimeOffset.Parse(EndTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "categories")]
        public List<string> Categories { get; private set; }

        [JsonProperty(PropertyName = "end")]
        private string UpdatedTimeString { get; set; }

        [JsonIgnore]
        public ZonedDateTime LastUpdated {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(UpdatedTimeString));
                var o = DateTimeOffset.Parse(UpdatedTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
