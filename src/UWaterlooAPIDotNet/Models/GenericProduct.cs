using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericProduct
    {
        [JsonProperty(PropertyName = "product_name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "product_id")]
        public int? ID { get; private set; }
    }
}
