using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class BasicEvent
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "times")]
        public List<EventTimes> Times { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }

        [JsonProperty(PropertyName = "updated")]
        private string UpdatedTimeString { get; set; }

        [JsonIgnore]
        public ZonedDateTime UpdatedTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(UpdatedTimeString));
                var o = DateTimeOffset.Parse(UpdatedTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }
    }
}
