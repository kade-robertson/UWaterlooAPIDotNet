using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class DietInfo
    {
        [JsonProperty(PropertyName = "diet_id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "diet_type")]
        public string Name { get; private set; }
    }
}
