using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class AwardDeadlines
    {
        [JsonProperty(PropertyName = "term")]
        public List<string> Term { get; private set; }

        [JsonProperty(PropertyName = "application")]
        public List<string> Application { get; private set; }

        [JsonProperty(PropertyName = "extended")]
        public string Extended { get; private set; }
    }
}
