using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class Holiday
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; private set; }
    }
}
