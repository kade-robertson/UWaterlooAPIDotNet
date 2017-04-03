using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class DelegatedAuthor
    {
        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "attributes")]
        public Dictionary<string, string> Attributes { get; private set; }

        [JsonProperty(PropertyName = "html")]
        public bool HTML { get; private set; }

        [JsonProperty(PropertyName = "display_url")]
        public Uri DisplayURL { get; private set; }
    }
}
