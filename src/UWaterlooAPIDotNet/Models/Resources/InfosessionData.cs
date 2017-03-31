using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NodaTime;
using System;
using System.Collections.Generic;
using UWaterlooAPIDotNet.Converters;

namespace UWaterlooAPIDotNet.Models.Resources
{
    public class InfosessionData
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "employer")]
        public string Employer { get; private set; }

        [JsonProperty(PropertyName = "date")]
        private string DateString { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string DayOfWeek { get; private set; }

        [JsonProperty(PropertyName = "start_time")]
        private string StartTimeString { get; set; }

        [JsonProperty(PropertyName = "end_time")]
        private string EndTimeString { get; set; }

        [JsonIgnore]
        public DateTime? StartTime {
            get {
                return DateTime.ParseExact(DateString + " " + StartTimeString, @"yyyy-MM-dd HH\:mm", null);
            }
        }

        [JsonIgnore]
        public DateTime? EndTime {
            get {
                return DateTime.ParseExact(DateString + " " + EndTimeString, @"yyyy-MM-dd HH\:mm", null);
            }
        }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "website")]
        [JsonConverter(typeof(StringUriConverter))]
        public Uri Website { get; private set; }

        [JsonProperty(PropertyName = "building")]
        public InfosessionBuilding Building { get; private set; }

        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }
    }
}
