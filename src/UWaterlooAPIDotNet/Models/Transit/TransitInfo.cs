using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Transit
{
    public class TransitInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }

        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; private set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; private set; }

        [JsonProperty(PropertyName = "phone")]
        public string PhoneNumber { get; private set; }
    }
}
