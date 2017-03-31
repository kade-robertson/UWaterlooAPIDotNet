using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Change
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "changes")]
        public List<string> Changes { get; private set; }
    }
}
