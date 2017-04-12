using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedAdditionalInfo
    {
        /// <summary>
        /// A link to the menu of the location (if available).
        /// </summary>
        [JsonProperty(PropertyName = "menu_url")]
        public Uri MenuURL { get; private set; }
    }
}
