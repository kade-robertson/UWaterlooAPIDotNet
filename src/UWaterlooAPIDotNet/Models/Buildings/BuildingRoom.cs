using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using NodaTime;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingRoom
    {
        [JsonProperty(PropertyName = "class_number")]
        public int? ClassNumber { get; private set; }

        [JsonProperty(PropertyName = "subject")]
        public string SubjectCode { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "section")]
        public string Section { get; private set; }

        [JsonProperty(PropertyName = "weekdays")]
        public string WeekDays { get; private set; }

        [JsonProperty(PropertyName = "start_time")]
        public string StartTime { get; private set; }

        [JsonProperty(PropertyName = "end_time")]
        public string EndTime { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; private set; }

        [JsonProperty(PropertyName = "enrollment_total")]
        public int? EnrollmentTotal { get; private set; }

        [JsonProperty(PropertyName = "instructors")]
        public List<string> Instructors { get; private set; }

        [JsonProperty(PropertyName = "building")]
        public string BuildingCode { get; private set; }

        [JsonProperty(PropertyName = "room")]
        public string RoomNumber { get; private set; }

        [JsonProperty(PropertyName = "term")]
        public int? Term { get; private set; }

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
