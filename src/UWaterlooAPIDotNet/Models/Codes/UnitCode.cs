using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class UnitCode
    {
        [JsonProperty(PropertyName = "unit_code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "group_code")]
        public string GroupCode { get; private set; }

        [JsonProperty(PropertyName = "unit_short_name")]
        public string ShortName { get; private set; }

        [JsonProperty(PropertyName = "unit_full_name")]
        public string FullName { get; private set; }
    }
}
