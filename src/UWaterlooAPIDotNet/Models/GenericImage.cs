using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericImage
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "file")]
        public string Filename { get; private set; }

        [JsonProperty(PropertyName = "alt")]
        public string AlternateText { get; private set; }

        [JsonProperty(PropertyName = "mime")]
        public string MIMEType { get; private set; }

        [JsonProperty(PropertyName = "size")]
        public int? FileSize { get; private set; }

        [JsonProperty(PropertyName = "width")]
        public int? Width { get; private set; }

        [JsonProperty(PropertyName = "height")]
        public int? Height { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
