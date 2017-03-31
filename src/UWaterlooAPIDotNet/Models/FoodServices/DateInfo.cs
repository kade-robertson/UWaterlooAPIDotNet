using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class DateInfo
    {
        [JsonProperty(PropertyName = "week")]
        public int? Week { get; private set; }

        [JsonProperty(PropertyName = "year")]
        public int? Year { get; private set; }

        [JsonProperty(PropertyName = "start")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "end")]
        public DateTime? EndDate { get; private set; }
    }
}
