using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class EventTimes
    {
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
    }
}
