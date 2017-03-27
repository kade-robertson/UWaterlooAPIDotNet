using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class Response<T> 
    {
        [JsonProperty(PropertyName = "meta")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "data")]
        public T Data { get; private set; }
    }
}
