using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class CourseEnrollment
    {
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "class_number")]
        public int? ClassNumber { get; private set; }

        [JsonProperty(PropertyName = "section")]
        public string Section { get; private set; }

        [JsonProperty(PropertyName = "enrollment_capacity")]
        public int? EnrollmentCapacity { get; private set; }

        [JsonProperty(PropertyName = "enrollment_total")]
        public int? EnrollmentTotal { get; private set; }

        [JsonProperty(PropertyName = "waiting_capacity")]
        public int? WaitingListCapacity { get; private set; }

        [JsonProperty(PropertyName = "waiting_total")]
        public int? WaitingListTotal { get; private set; }
    }
}
