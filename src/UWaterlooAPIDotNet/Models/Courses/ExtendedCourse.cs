using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class ExtendedCourse : Course
    {
        /// <summary>
        /// A <see cref="List{T}"/> of instruction types for the course.
        /// </summary>
        [JsonProperty(PropertyName = "instructions")]
        public List<string> Instructions { get; private set; }

        /// <summary>
        /// The prerequisites for the course, if any.
        /// </summary>
        [JsonProperty(PropertyName = "prerequisites")]
        public string Prerequisites { get; private set; }

        /// <summary>
        /// The antirequisites for the course, if any.
        /// </summary>
        [JsonProperty(PropertyName = "antirequisites")]
        public string Antirequisites { get; private set; }

        /// <summary>
        /// The corequisites for the course, if any.
        /// </summary>
        [JsonProperty(PropertyName = "corequisites")]
        public string Corequisites { get; private set; }

        /// <summary>
        /// The cross-listed course(s), if any.
        /// </summary>
        [JsonProperty(PropertyName = "crosslistings")]
        public string CrossListings { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of terms the course is offered in.
        /// </summary>
        [JsonProperty(PropertyName = "terms_offered")]
        public List<string> TermsOffered { get; private set; }

        /// <summary>
        /// Additional notes for the course.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; private set; }

        /// <summary>
        /// Provides <see cref="OfferingData"/> on where the course is offered.
        /// </summary>
        [JsonProperty(PropertyName = "offerings")]
        public OfferingData Offerings { get; private set; }

        /// <summary>
        /// Indicates whether the course requires consent from the department it is in to enrol.
        /// </summary>
        [JsonProperty(PropertyName = "needs_department_consent")]
        public bool NeedsDepartmentConsent { get; private set; }

        /// <summary>
        /// Indicates whether the course requires consent from the course instructor to enrol.
        /// </summary>
        [JsonProperty(PropertyName = "needs_instructor_consent")]
        public bool NeedsInstructorConsent { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of extra course information.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public List<string> ExtraInfo { get; private set; }

        /// <summary>
        /// The calendar year of the course.
        /// </summary>
        [JsonProperty(PropertyName = "calendar_year")]
        public string CalendarYear { get; private set; }

        /// <summary>
        /// A link to the course on the course calendar.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
