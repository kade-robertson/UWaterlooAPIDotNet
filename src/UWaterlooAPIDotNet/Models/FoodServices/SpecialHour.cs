using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class SpecialHour : GenericHours
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; private set; }
    }
}
