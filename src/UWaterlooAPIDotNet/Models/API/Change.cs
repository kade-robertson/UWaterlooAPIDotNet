using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Change
    {
        /// <summary>
        /// The date which the change(s) were applied on.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// A list of strings indicating what changes were made.
        /// </summary>
        [JsonProperty(PropertyName = "changes")]
        public List<string> Changes { get; private set; }
    }
}
