using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class WatcardLocation
    {
        [JsonProperty(PropertyName = "vendor_id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "vendor_name")]
        public string Name { get; private set; }
    }
}
