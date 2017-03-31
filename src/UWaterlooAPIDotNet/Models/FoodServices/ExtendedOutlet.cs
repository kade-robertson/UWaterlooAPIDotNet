using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UWaterlooAPIDotNet.Converters;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class ExtendedOutlet : GenericOutlet 
    {
        [JsonProperty(PropertyName = "building")]
        public string Building { get; private set; }

        [JsonProperty(PropertyName = "logo")]
        [JsonConverter(typeof(StringUriConverter))]
        public Uri Logo { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "notice")]
        public string Notice { get; private set; }

        [JsonProperty(PropertyName = "opening_hours")]
        public OpeningHours OpeningHours { get; private set; }

        [JsonProperty(PropertyName = "special_hours")]
        public List<SpecialHour> SpecialHours { get; private set; }

        [JsonProperty(PropertyName = "dates_closed")]
        public List<DateTime> DatesClosed { get; private set; }
    }
}
