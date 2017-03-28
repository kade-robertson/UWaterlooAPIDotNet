using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.PointsOfInterest
{
    public class VisitorInfo : PointOfInterest
    {
        [JsonProperty(PropertyName = "opening_hours")]
        public string OpeningHours { get; private set; }

        [JsonProperty(PropertyName = "phone")]
        public string PhoneNumber { get; private set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
