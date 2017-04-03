using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class Award
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "citizenship")]
        public List<string> Citizenship { get; private set; }

        [JsonProperty(PropertyName = "programs")]
        public List<string> Programs { get; private set; }

        [JsonProperty(PropertyName = "application")]
        public ApplicationInfo ApplicationInfo { get; private set; }

        [JsonProperty(PropertyName = "deadlines")]
        public AwardDeadlines Deadlines { get; private set; }

        [JsonProperty(PropertyName = "links")]
        public List<string> Links { get; private set; }

        [JsonProperty(PropertyName = "contact")]
        public string ContactInfo { get; private set; }

        [JsonProperty(PropertyName = "vid")]
        public int? RevisionID { get; private set; }

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }
    }
}
