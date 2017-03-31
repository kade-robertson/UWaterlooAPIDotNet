using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class MenuAnnouncement
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "ad_text")]
        public string Info { get; private set; }
    }
}
