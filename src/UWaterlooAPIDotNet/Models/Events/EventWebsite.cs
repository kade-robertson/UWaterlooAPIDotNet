using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class EventWebsite
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
