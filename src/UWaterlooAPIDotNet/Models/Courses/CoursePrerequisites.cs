using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class CoursePrerequisites 
    {
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "prerequisites")]
        public string Prerequisites { get; private set; }
    }
}
