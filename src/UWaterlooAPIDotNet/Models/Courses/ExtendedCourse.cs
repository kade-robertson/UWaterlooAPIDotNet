using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class ExtendedCourse
    {
        [JsonProperty(PropertyName = "instructions")]
        public List<string> Instructions { get; private set; }

        [JsonProperty(PropertyName = "prerequisites")]
        public string Prerequisites { get; private set; }

        [JsonProperty(PropertyName = "antirequisites")]
        public string Antirequisites { get; private set; }

        [JsonProperty(PropertyName = "corequisites")]
        public string Corequisites { get; private set; }

        [JsonProperty(PropertyName = "crosslistings")]
        public string CrossListings { get; private set; }

        [JsonProperty(PropertyName = "terms_offered")]
        public List<string> TermsOffered { get; private set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; private set; }

        [JsonProperty(PropertyName = "offerings")]
        public OfferingData Offerings { get; private set; }

        [JsonProperty(PropertyName = "needs_department_consent")]
        public bool NeedsDepartmentConsent { get; private set; }

        [JsonProperty(PropertyName = "needs_instructor_consent")]
        public bool NeedsInstructorConsent { get; private set; }

        [JsonProperty(PropertyName = "extra")]
        public List<string> ExtraInfo { get; private set; }

        [JsonProperty(PropertyName = "calendar_year")]
        public string CalendarYear { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
