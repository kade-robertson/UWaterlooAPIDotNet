using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Usage
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "api_key")]
        public string APIKey { get; private set; }

        [JsonProperty(PropertyName = "monthly_calls")]
        public int MonthlyCalls { get; private set; }

        [JsonProperty(PropertyName = "total_calls")]
        public int TotalCalls { get; private set; }
    }
}
