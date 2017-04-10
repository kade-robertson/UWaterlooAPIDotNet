using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class SubjectCode
    {
        /// <summary>
        /// The code for the subject.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Code { get; private set; }

        /// <summary>
        /// The description of the subject.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// The code for the unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string UnitCode { get; private set; }

        /// <summary>
        /// The code for the group.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string GroupCode { get; private set; }
    }
}
