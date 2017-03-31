using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class OutletCollection
    {
        [JsonProperty(PropertyName = "date")]
        public DateInfo Date { get; private set; }

        [JsonProperty(PropertyName = "outlets")]
        public List<Outlet> Outlets { get; private set; }
    }
}
