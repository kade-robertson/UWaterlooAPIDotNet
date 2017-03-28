using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class AccessPoint
    {
        [JsonProperty(PropertyName = "ap_name")]
        public string APName { get; private set; }

        [JsonProperty(PropertyName = "ssid")]
        public string SSID { get; private set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; private set; }

        [JsonProperty(PropertyName = "mac_address")]
        public string MACAddress { get; private set; }

        [JsonProperty(PropertyName = "mac_address_secondary")]
        public string SecondaryMACAddress { get; private set; }

        [JsonProperty(PropertyName = "aruba_ap_model")]
        public string ArubaAPModel { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "floor")]
        public int? Floor { get; private set; }

        [JsonProperty(PropertyName = "building_code")]
        public string BuildingCode { get; private set; }
    }
}
