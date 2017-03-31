using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class Meals
    {
        [JsonProperty(PropertyName = "lunch")]
        public List<FoodItem> Lunch { get; private set; }

        [JsonProperty(PropertyName = "dinner")]
        public List<FoodItem> Dinner { get; private set; }
    }
}
