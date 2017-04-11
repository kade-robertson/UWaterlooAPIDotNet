using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class CoursePrerequisites 
    {
        /// <summary>
        /// The subject the course belongs to.
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

        /// <summary>
        /// The prerequisites for taking the course, if applicable.
        /// </summary>
        [JsonProperty(PropertyName = "prerequisites")]
        public string Prerequisites { get; private set; }
    }
}
