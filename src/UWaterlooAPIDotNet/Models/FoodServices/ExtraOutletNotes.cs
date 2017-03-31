using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class ExtraOutletNotes : GenericOutlet
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; private set; }
    }
}
