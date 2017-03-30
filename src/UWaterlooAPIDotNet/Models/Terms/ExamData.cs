using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ExamData
    {
        [JsonProperty(PropertyName = "course")]
        public string Course { get; private set; }

        [JsonProperty(PropertyName = "sections")]
        public List<ExamSection> Sections { get; private set; }
    }
}
