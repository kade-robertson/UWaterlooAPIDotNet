using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Method
    {
        [JsonProperty(PropertyName = "method_id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "method_url")]
        public string URL { get; private set; }

        [JsonProperty(PropertyName = "service_id")]
        public int? ServiceID { get; private set; }

        [JsonProperty(PropertyName = "service_name")]
        public string ServiceName { get; private set; }

        [JsonProperty(PropertyName = "parameters")]
        public List<string> Parameters { get; private set; }
    }
}
