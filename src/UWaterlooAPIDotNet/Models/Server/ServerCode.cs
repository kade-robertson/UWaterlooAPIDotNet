using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Server
{
    public class ServerCode 
    {
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; private set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }
    }
}
