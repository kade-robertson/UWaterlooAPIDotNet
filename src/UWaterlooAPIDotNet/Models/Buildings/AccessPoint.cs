using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class AccessPoint
    {
        [JsonIgnore]
        [Obsolete("The Name property should be used instead of APName. APName is now an alias and will be removed with 2.0.0.")]
        public string APName { get; private set; }

        /// <summary>
        /// The name of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "ap_name")]
        public string Name { get; private set; }

        /// <summary>
        /// The SSID of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "ssid")]
        public string SSID { get; private set; }

        /// <summary>
        /// The associated IP address of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; private set; }

        /// <summary>
        /// The primary MAC address of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string MACAddress { get; private set; }

        /// <summary>
        /// The secondary MAC address of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address_secondary")]
        public string SecondaryMACAddress { get; private set; }

        /// <summary>
        /// The specific model of the access point.
        /// </summary>
        [JsonProperty(PropertyName = "aruba_ap_model")]
        public string ArubaAPModel { get; private set; }

        /// <summary>
        /// The latitude of the access point in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        /// <summary>
        /// The longitude of the access point in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        /// <summary>
        /// The floor number on which the access point is located.
        /// </summary>
        [JsonProperty(PropertyName = "floor")]
        public int? Floor { get; private set; }

        /// <summary>
        /// The code for the building the AP is in.
        /// </summary>
        [JsonProperty(PropertyName = "building_code")]
        public string BuildingCode { get; private set; }
    }
}
