using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class Changelog
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; private set; }

        [JsonProperty(PropertyName = "changes")]
        public List<string> Changes { get; private set; }
    }
}
