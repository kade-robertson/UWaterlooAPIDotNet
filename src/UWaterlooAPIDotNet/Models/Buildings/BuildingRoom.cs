using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using NodaTime;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class BuildingRoom
    {
        /// <summary>
        /// The number of the class which takes place in this room.
        /// </summary>
        [JsonProperty(PropertyName = "class_number")]
        public int? ClassNumber { get; private set; }

        /// <summary>
        /// The subject code of the class in this room.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string SubjectCode { get; private set; }

        /// <summary>
        /// The catalog number of the class in this room.
        /// </summary>
        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }
        
        /// <summary>
        /// The full name of the class in this room.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        /// <summary>
        /// The particular section of the class.
        /// </summary>
        [JsonProperty(PropertyName = "section")]
        public string Section { get; private set; }

        /// <summary>
        /// The days of the week the class occupies the room.
        /// </summary>
        [JsonProperty(PropertyName = "weekdays")]
        public string WeekDays { get; private set; }

        /// <summary>
        /// The time at which class starts for this section.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string StartTime { get; private set; }

        /// <summary>
        /// The time at which class ends for this section.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string EndTime { get; private set; }

        /// <summary>
        /// The start date of the room usage, if applicable.
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        /// <summary>
        /// The end date of the room usage, if available.
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// The number of students enrolled in the particular section.
        /// </summary>
        [JsonProperty(PropertyName = "enrollment_total")]
        public int? EnrollmentTotal { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of instructors for the section.
        /// </summary>
        [JsonProperty(PropertyName = "instructors")]
        public List<string> Instructors { get; private set; }

        /// <summary>
        /// The building in which the room resides.
        /// </summary>
        [JsonProperty(PropertyName = "building")]
        public string BuildingCode { get; private set; }

        /// <summary>
        /// The number of the room.
        /// </summary>
        [JsonProperty(PropertyName = "room")]
        public string RoomNumber { get; private set; }

        /// <summary>
        /// The term of the current class.
        /// </summary>
        [JsonProperty(PropertyName = "term")]
        public int? Term { get; private set; }

        [JsonProperty(PropertyName = "last_updated")]
        private string LastUpdatedString { get; set; }

        /// <summary>
        /// The last time the building room information was updated.
        /// </summary>
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
