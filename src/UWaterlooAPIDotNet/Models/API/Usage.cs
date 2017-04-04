using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Usage
    {
        /// <summary>
        /// The name related to the API key.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// The API key the usage statistics apply to.
        /// </summary>
        [JsonProperty(PropertyName = "api_key")]
        public string APIKey { get; private set; }

        /// <summary>
        /// The number of calls made in the current month by the given API key.
        /// </summary>
        [JsonProperty(PropertyName = "monthly_calls")]
        public int? MonthlyCalls { get; private set; }

        /// <summary>
        /// The number of calls made in total by the given API key.
        /// </summary>
        [JsonProperty(PropertyName = "total_calls")]
        public int? TotalCalls { get; private set; }
    }
}
