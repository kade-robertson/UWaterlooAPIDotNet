using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class OfferingData
    {
        [JsonProperty(PropertyName = "online")]
        public bool Online { get; private set; }

        [JsonProperty(PropertyName = "online_only")]
        public bool OnlineOnly { get; private set; }

        [JsonProperty(PropertyName = "st_jerome")]
        public bool StJerome { get; private set; }

        [JsonProperty(PropertyName = "st_jerome_only")]
        public bool StJeromeOnly { get; private set; }

        [JsonProperty(PropertyName = "renison")]
        public bool Renison { get; private set; }

        [JsonProperty(PropertyName = "renison_only")]
        public bool RenisonOnly { get; private set; }

        [JsonProperty(PropertyName = "conrad_grebel")]
        public bool ConradGrebel { get; private set; }

        [JsonProperty(PropertyName = "conrad_grebel_only")]
        public bool ConradGrebelOnly { get; private set; }
    }
}
