using System;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Version
    {
        /// <summary>
        /// The version number as a decimal.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public decimal? VersionNumber { get; private set; }

        /// <summary>
        /// The date the version was released.
        /// </summary>
        [JsonProperty(PropertyName = "release_date")]
        public DateTime? ReleaseDate { get; private set; }
    }
}
