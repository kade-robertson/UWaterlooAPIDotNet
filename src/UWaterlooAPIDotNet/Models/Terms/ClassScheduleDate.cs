using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ClassScheduleDate
    {
        [JsonProperty(PropertyName = "start_time")]
        public string StartTime { get; private set; }

        [JsonProperty(PropertyName = "end_time")]
        public string EndTime { get; private set; }

        [JsonProperty(PropertyName = "weekdays")]
        public string Weekdays { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; private set; }

        [JsonProperty(PropertyName = "is_tba")]
        public bool IsTBA { get; private set; }

        [JsonProperty(PropertyName = "is_cancelled")]
        public bool IsCancelled { get; private set; }

        [JsonProperty(PropertyName = "is_closed")]
        public bool IsClosed { get; private set; }
    }
}
