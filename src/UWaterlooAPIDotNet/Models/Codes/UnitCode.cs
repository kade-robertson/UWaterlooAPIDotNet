using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class UnitCode
    {
        /// <summary>
        /// The code for the unit
        /// </summary>
        [JsonProperty(PropertyName = "unit_code")]
        public string Code { get; private set; }

        /// <summary>
        /// The code for the associated group.
        /// </summary>
        [JsonProperty(PropertyName = "group_code")]
        public string GroupCode { get; private set; }

        /// <summary>
        /// The short name of the unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit_short_name")]
        public string ShortName { get; private set; }

        /// <summary>
        /// The full name of the unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit_full_name")]
        public string FullName { get; private set; }
    }
}
