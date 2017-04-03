using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class BasicCourse
    {
        [JsonProperty(PropertyName = "course_id")]
        public string ID { get; private set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }
    }
}
