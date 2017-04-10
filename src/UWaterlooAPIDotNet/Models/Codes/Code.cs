using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Codes
{
    public class Code
    {
        /// <summary>
        /// The abbreviated code name.
        /// </summary>
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; private set; }

        /// <summary>
        /// The description of the code.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }
    }
}
