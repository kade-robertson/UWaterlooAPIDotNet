using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedEventEx : FedEvent
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }
    }
}
