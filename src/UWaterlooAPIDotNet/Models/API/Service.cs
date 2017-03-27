using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Service 
    {
        [JsonProperty(PropertyName = "service_id")]
        public int ID { get; private set; }

        [JsonProperty(PropertyName = "service_name")]
        public int Name { get; private set; }

        [JsonProperty(PropertyName = "service_url")]
        public int URL { get; private set; }

        [JsonProperty(PropertyName = "methods")]
        public List<Method> Methods { get; private set; }
    }
}
