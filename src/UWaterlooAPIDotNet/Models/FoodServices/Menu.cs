using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class Menu
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime? val { get; private set; }

        [JsonProperty(PropertyName = "day")]
        public string DayOfWeek { get; private set; }

        [JsonProperty(PropertyName = "meals")]
        public Meals Meals { get; private set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; private set; }
    }
}
