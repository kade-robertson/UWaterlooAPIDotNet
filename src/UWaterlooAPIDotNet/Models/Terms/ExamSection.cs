using System;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ExamSection
    {
        [JsonProperty(PropertyName = "section")]
        public string Section { get; private set; }

        [JsonProperty(PropertyName = "day")]
        public string DayOfWeek { get; private set; }

        [JsonProperty(PropertyName = "date")]
        private string DateString { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        private string StartTimeString { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        private string EndTimeString { get; set; }

        [JsonIgnore]
        public DateTime StartTime {
            get {
                return DateTime.ParseExact(DateString + " " + StartTimeString, @"yyyy-MM-dd h\:mm tt", null);
            }
        }

        [JsonIgnore]
        public DateTime EndTime {
            get {
                return DateTime.ParseExact(DateString + " " + EndTimeString, @"yyyy-MM-dd h\:mm tt", null);
            }
        }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; private set; }
    }
}
