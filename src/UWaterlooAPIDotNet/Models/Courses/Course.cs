using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class Course : BasicCourse
    {
        [JsonProperty(PropertyName = "units")]
        public decimal? Units { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "academic_level")]
        public string AcademicLevel { get; private set; }
    }
}
