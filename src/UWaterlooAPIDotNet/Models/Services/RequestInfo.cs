using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Services
{
    public class RequestInfo
    {
        [JsonProperty(PropertyName = "procedure")]
        public string Procedure { get; private set; }

        [JsonProperty(PropertyName = "completion_time")]
        public string CompletionTime { get; private set; }

        [JsonProperty(PropertyName = "minimum_notice")]
        public string MinimumNotice { get; private set; }
    }
}
