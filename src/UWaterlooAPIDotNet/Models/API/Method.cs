using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Method
    {
        /// <summary>
        /// The ID of the method.
        /// </summary>
        [JsonProperty(PropertyName = "method_id")]
        public int? ID { get; private set; }

        /// <summary>
        /// The URL which points to the method.
        /// </summary>
        [Obsolete("It is recommended to use MethodURL until version 2.0.0. This will function as originally programmed until then.")]
        public string URL {
            get {
                return MethodURL.ToString();
            }
        }

        /// <summary>
        /// The URL which points to the method, as a Uri.
        /// </summary>
        [JsonProperty(PropertyName = "method_url")]
        public Uri MethodURL { get; private set; }

        /// <summary>
        /// The ID of the service.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public int? ServiceID { get; private set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string ServiceName { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of required parameters for using the method.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public List<string> Parameters { get; private set; }
    }
}
