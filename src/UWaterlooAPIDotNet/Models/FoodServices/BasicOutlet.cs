using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class BasicOutlet : GenericOutlet
    {
        [JsonProperty(PropertyName = "has_breakfast")]
        public bool HasBreakfast { get; private set; }

        [JsonProperty(PropertyName = "has_lunch")]
        public bool HasLunch { get; private set; }

        [JsonProperty(PropertyName = "has_dinner")]
        public bool HasDinner { get; private set; }
    }
}
