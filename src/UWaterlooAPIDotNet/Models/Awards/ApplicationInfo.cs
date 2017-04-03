using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class ApplicationInfo
    {
        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        [JsonProperty(PropertyName = "enrollment_years")]
        public List<string> EnrollmentYears { get; private set; }

        [JsonProperty(PropertyName = "eligibility")]
        public List<string> Eligibility { get; private set; }

        [JsonProperty(PropertyName = "instructions")]
        public List<string> Instructions { get; private set; }

        [JsonProperty(PropertyName = "additional")]
        public List<string> AdditionalInfo { get; private set; }
    }
}
