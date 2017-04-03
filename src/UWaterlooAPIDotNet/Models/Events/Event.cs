using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class Event : BasicEvent
    {
        [JsonProperty(PropertyName = "site")]
        public string Site { get; private set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }
    }
}
