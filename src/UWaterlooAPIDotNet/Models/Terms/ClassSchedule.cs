using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class ClassSchedule : CourseEnrollment
    {
        [JsonProperty(PropertyName = "units")]
        public decimal? Units { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; private set; }

        [JsonProperty(PropertyName = "campus")]
        public string Campus { get; private set; }

        [JsonProperty(PropertyName = "associated_class")]
        public int? AssociatedClass { get; private set; }

        [JsonProperty(PropertyName = "related_component_1")]
        public string RelatedComponent { get; private set; }

        [JsonProperty(PropertyName = "related_component_2")]
        public string SecondRelatedComponent { get; private set; }

        [JsonProperty(PropertyName = "topic")]
        public string Topic { get; private set; }

        [JsonProperty(PropertyName = "reserves")]
        public List<ReserveData> Reserves { get; private set; }

        [JsonProperty(PropertyName = "classes")]
        public List<ClassScheduleDetail> Classes { get; private set; }

        [JsonProperty(PropertyName = "held_with")]
        public List<string> HeldWith { get; private set; }

        [JsonProperty(PropertyName = "term")]
        public int? Term { get; private set; }

        [JsonProperty(PropertyName = "academic_level")]
        public string AcademicLevel { get; private set; }

        [JsonProperty(PropertyName = "last_updated")]
        private string LastUpdatedString { get; set; }

        [JsonIgnore]
        public ZonedDateTime LastUpdated {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(LastUpdatedString));
                var o = DateTimeOffset.Parse(LastUpdatedString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }
    }
}
