using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class ApplicationInfo
    {
        /// <summary>
        /// Information on how to apply for the award.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        /// <summary>
        /// Required program level to qualify for the award.
        /// </summary>
        [JsonProperty(PropertyName = "enrollment_years")]
        public List<string> EnrollmentYears { get; private set; }

        /// <summary>
        /// Details on award eligibility.
        /// </summary>
        [JsonProperty(PropertyName = "eligibility")]
        public List<string> Eligibility { get; private set; }

        /// <summary>
        /// Instructions on applying for the award.
        /// </summary>
        [JsonProperty(PropertyName = "instructions")]
        public List<string> Instructions { get; private set; }

        /// <summary>
        /// Any additional information for the application process.
        /// </summary>
        [JsonProperty(PropertyName = "additional")]
        public List<string> AdditionalInfo { get; private set; }
    }
}
