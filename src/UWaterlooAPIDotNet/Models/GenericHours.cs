using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericHours
    {
        [JsonProperty(PropertyName = "opening_hour")]
        public string OpeningHour { get; private set; }

        [JsonProperty(PropertyName = "closing_hour")]
        public string ClosingHour { get; private set; }
    }
}
