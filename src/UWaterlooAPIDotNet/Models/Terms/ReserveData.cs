using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ReserveData
    {
        [JsonProperty(PropertyName = "reserve_group")]
        public string Group { get; private set; }

        [JsonProperty(PropertyName = "enrollment_capacity")]
        public int EnrollmentCapacity { get; private set; }

        [JsonProperty(PropertyName = "enrollment_total")]
        public int EnrollmentTotal { get; private set; }
    }
}
