using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Server
{
    public class TimeData
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; private set; }

        [JsonProperty(PropertyName = "datetime")]
        public DateTime DateTime { get; private set; }

        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; private set; }

        [JsonProperty(PropertyName = "key_reset_time")]
        public long KeyResetTimestamp { get; private set; }

        [JsonIgnore]
        public DateTime KeyResetTime {
            get {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(KeyResetTimestamp);
            }
        }
    }
}
