using System;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Version
    {
        [JsonProperty(PropertyName = "version")]
        public decimal? VersionNumber { get; private set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime ReleaseDate { get; private set; }
    }
}
