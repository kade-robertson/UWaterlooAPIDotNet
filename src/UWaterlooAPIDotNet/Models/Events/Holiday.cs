using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class Holiday
    {
        /// <summary>
        /// The name of the holiday in question.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// The date the holiday takes place on.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; private set; }
    }
}
