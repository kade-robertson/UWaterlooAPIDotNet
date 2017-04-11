using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Courses
{
    public class OfferingData
    {
        /// <summary>
        /// Indicates if the course is available online.
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        public bool Online { get; private set; }

        /// <summary>
        /// Indicates if the course is available online only.
        /// </summary>
        [JsonProperty(PropertyName = "online_only")]
        public bool OnlineOnly { get; private set; }

        /// <summary>
        /// Indicates if the course is available at St. Jerome's.
        /// </summary>
        [JsonProperty(PropertyName = "st_jerome")]
        public bool StJerome { get; private set; }

        /// <summary>
        /// Indicates if the course is available at St. Jerome's only. 
        /// </summary>
        [JsonProperty(PropertyName = "st_jerome_only")]
        public bool StJeromeOnly { get; private set; }

        /// <summary>
        /// Indicates if the course is available at Renison.
        /// </summary>
        [JsonProperty(PropertyName = "renison")]
        public bool Renison { get; private set; }

        /// <summary>
        /// Indicates if the course is available at Renison only.
        /// </summary>
        [JsonProperty(PropertyName = "renison_only")]
        public bool RenisonOnly { get; private set; }

        /// <summary>
        /// Indicates if the course is available at Conrad Grebel.
        /// </summary>
        [JsonProperty(PropertyName = "conrad_grebel")]
        public bool ConradGrebel { get; private set; }

        /// <summary>
        /// Indicates if the course is available at Conrad Grebel only.
        /// </summary>
        [JsonProperty(PropertyName = "conrad_grebel_only")]
        public bool ConradGrebelOnly { get; private set; }
    }
}
