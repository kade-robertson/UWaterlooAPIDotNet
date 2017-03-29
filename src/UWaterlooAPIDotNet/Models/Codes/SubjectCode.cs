using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class SubjectCode
    {
        [JsonProperty(PropertyName = "subject")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "unit")]
        public string UnitCode { get; private set; }

        [JsonProperty(PropertyName = "group")]
        public string GroupCode { get; private set; }
    }
}
