using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class Metadata
    {
        [JsonProperty(PropertyName = "requests")]
        public int Requests { get; private set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; private set; }

        [JsonIgnore]
        public DateTime Time {
            get {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.Timestamp);
            }
        }

        [JsonProperty(PropertyName = "status")]
        public int StatusCode { get; private set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        [JsonProperty(PropertyName = "method_id")]
        public int MethodID { get; private set; }

        [JsonProperty(PropertyName = "method")]
        public Dictionary<string, string> Method { get; private set; }
    }
}
