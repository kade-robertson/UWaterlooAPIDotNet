using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class GroupCode
    {
        /// <summary>
        /// The code for the group.
        /// </summary>
        [JsonProperty(PropertyName = "group_code")]
        public string Code { get; private set; }

        /// <summary>
        /// The short name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "group_short_name")]
        public string ShortName { get; private set; }

        /// <summary>
        /// The full name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "group_full_name")]
        public string FullName { get; private set; }
    }
}
