using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ClassScheduleLocation
    {
        [JsonProperty(PropertyName = "building")]
        public string Building { get; private set; }

        [JsonProperty(PropertyName = "room")]
        public string Room { get; private set; }
    }
}
