using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class EventWebsite
    {
        /// <summary>
        /// The title of the event website.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        /// <summary>
        /// The link to the event website.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
