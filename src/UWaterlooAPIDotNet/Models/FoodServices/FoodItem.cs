using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class FoodItem : GenericProduct
    {
        [JsonProperty(PropertyName = "diet_type")]
        public string DietType { get; private set; }
    }
}
