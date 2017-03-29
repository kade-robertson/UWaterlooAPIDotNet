using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class GroupCode
    {
        [JsonProperty(PropertyName = "group_code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "group_short_name")]
        public string ShortName { get; private set; }

        [JsonProperty(PropertyName = "group_full_name")]
        public string FullName { get; private set; }
    }
}
