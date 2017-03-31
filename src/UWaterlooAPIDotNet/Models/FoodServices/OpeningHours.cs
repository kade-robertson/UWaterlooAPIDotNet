using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class OpeningHours
    {
        [JsonProperty(PropertyName = "sunday")]
        public OpeningInfo Sunday { get; private set; }

        [JsonProperty(PropertyName = "monday")]
        public OpeningInfo Monday { get; private set; }

        [JsonProperty(PropertyName = "tuesday")]
        public OpeningInfo Tuesday { get; private set; }

        [JsonProperty(PropertyName = "wednesday")]
        public OpeningInfo Wednesday { get; private set; }

        [JsonProperty(PropertyName = "thursday")]
        public OpeningInfo Thursday { get; private set; }

        [JsonProperty(PropertyName = "friday")]
        public OpeningInfo Friday { get; private set; }

        [JsonProperty(PropertyName = "saturday")]
        public OpeningInfo Saturday { get; private set; }
    }
}
