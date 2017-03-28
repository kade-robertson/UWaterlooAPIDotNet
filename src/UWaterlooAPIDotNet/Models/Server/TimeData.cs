using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Server
{
    public class TimeData
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; private set; }

        [JsonProperty(PropertyName = "datetime")]
        private string DateString { get; set; }

        [JsonIgnore]
        public ZonedDateTime DateTime {
            get {
                var i = new Instant();
                var o = DateTimeOffset.Parse(DateString);
                i += Duration.FromSeconds(Timestamp);
                return new ZonedDateTime(i, DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; private set; }

        [JsonProperty(PropertyName = "key_reset_time")]
        public long KeyResetTimestamp { get; private set; }

        [JsonIgnore]
        public ZonedDateTime KeyResetTime {
            get {
                var i = new Instant();
                i += Duration.FromSeconds(KeyResetTimestamp);
                return new ZonedDateTime(i, DateTime.Zone);
            }
        }
    }
}
