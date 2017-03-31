using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class OpeningInfo : GenericHours
    {
        [JsonProperty(PropertyName = "is_closed")]
        public bool IsClosed { get; private set; }
    }
}
