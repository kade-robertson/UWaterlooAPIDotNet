using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.API
{
    public class Service {
        /// <summary>
        /// The ID of the service.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public int? ID { get; private set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [Obsolete("This was made in error, please use ServiceName until version 2.0.0.This will function as originally programmed until then.")]
        public int? Name {
            get {
                var x = 0;
                int.TryParse(ServiceName, out x);
                return x;
            }
        }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string ServiceName { get; private set; }


        /// <summary>
        /// The URL to the service.
        /// </summary>
        [Obsolete("This was made in error, please use ServiceURL until version 2.0.0. This will function as originally programmed until then.")]
        public int? URL {
            get {
                var x = 0;
                int.TryParse(ServiceURL.ToString(), out x);
                return x;
            }
        }

        /// <summary>
        /// The URL to the service, as a Uri object.
        /// </summary>
        [JsonProperty(PropertyName = "service_url")]
        public Uri ServiceURL { get; private set; }

        /// <summary>
        /// The <see cref="List{T}"/> of <see cref="Method"/> available with the service.
        /// </summary>
        [JsonProperty(PropertyName = "methods")]
        public List<Method> Methods { get; private set; }
    }
}
