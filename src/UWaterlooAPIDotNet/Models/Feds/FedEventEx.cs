using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedEventEx : FedEvent
    {
        /// <summary>
        /// A description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// A raw description of the event, including HTML elements.
        /// </summary>
        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }
    }
}
