using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class Course : BasicCourse
    {
        /// <summary>
        /// The amount of earned units for completing the course.
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public decimal? Units { get; private set; }

        /// <summary>
        /// A description of the course content.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// The academic level required to take the course.
        /// </summary>
        [JsonProperty(PropertyName = "academic_level")]
        public string AcademicLevel { get; private set; }
    }
}
