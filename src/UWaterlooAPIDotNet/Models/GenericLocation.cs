using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class GenericLocation
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "street")]
        public string Street { get; private set; }

        [JsonProperty(PropertyName = "additional")]
        public string AdditionalInfo { get; private set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; private set; }

        [JsonProperty(PropertyName = "province")]
        public string Province { get; private set; }

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; private set; }

        [JsonProperty(PropertyName = "country")]
        public string Canada { get; private set; }

        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }
    }
}
