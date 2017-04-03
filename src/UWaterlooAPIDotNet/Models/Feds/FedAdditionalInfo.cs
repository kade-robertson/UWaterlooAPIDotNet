using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedAdditionalInfo
    {
        [JsonProperty(PropertyName = "menu_url")]
        public Uri MenuURL { get; private set; }
    }
}
