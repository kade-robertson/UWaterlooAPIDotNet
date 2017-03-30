using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ClassScheduleDetail
    {
        [JsonProperty(PropertyName = "date")]
        public ClassScheduleDate Dates { get; private set; }

        [JsonProperty(PropertyName = "location")]
        public ClassScheduleLocation Location { get; private set; }

        [JsonProperty(PropertyName = "instructors")]
        public List<string> Instructors { get; private set; }
    }
}
