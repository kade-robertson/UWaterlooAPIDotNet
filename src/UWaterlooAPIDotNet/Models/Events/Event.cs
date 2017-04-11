using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class Event : BasicEvent
    {
        /// <summary>
        /// The site associated with the event.
        /// </summary>
        [JsonProperty(PropertyName = "site")]
        public string Site { get; private set; }

        /// <summary>
        /// The name of the side associated with the event.
        /// </summary>
        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }
    }
}
