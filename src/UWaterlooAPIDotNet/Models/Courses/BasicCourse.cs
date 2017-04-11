using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class BasicCourse
    {
        /// <summary>
        /// The course ID.
        /// </summary>
        [JsonProperty(PropertyName = "course_id")]
        public string ID { get; private set; }

        /// <summary>
        /// The subject of the course.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        /// <summary>
        /// The catalog number of the course.
        /// </summary>
        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        /// <summary>
        /// The name of the course.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }
    }
}
