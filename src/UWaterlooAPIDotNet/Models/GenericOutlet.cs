using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericOutlet
    {
        [JsonProperty(PropertyName = "outlet_id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "outlet_name")]
        public string Name { get; private set; }
    }
}
