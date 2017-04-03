using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class ExtendedEvent : Event
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; private set; }

        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; private set; }

        [JsonProperty(PropertyName = "website")]
        public EventWebsite Website { get; private set; }

        [JsonProperty(PropertyName = "host")]
        public EventWebsite Host { get; private set; }

        [JsonProperty(PropertyName = "image")]
        public GenericImage Image { get; private set; }

        [JsonProperty(PropertyName = "location")]
        public GenericLocation Location { get; private set; }

        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }

        [JsonProperty(PropertyName = "link_calendar")]
        public Uri CalendarLink { get; private set; }
    }
}
