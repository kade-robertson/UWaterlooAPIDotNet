using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class AwardDeadlines
    {
        /// <summary>
        /// A list of terms the award is offered in.
        /// </summary>
        [JsonProperty(PropertyName = "term")]
        public List<string> Term { get; private set; }

        /// <summary>
        /// Application deadlines for each term.
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public List<string> Application { get; private set; }

        /// <summary>
        /// An additional, extended deadline (if applicable).
        /// </summary>
        [JsonProperty(PropertyName = "extended")]
        public string Extended { get; private set; }
    }
}
