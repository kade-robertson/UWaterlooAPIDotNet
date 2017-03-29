using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class Code
    {
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }
    }
}
