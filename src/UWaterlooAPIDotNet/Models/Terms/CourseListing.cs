using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class CourseListing
    {
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "units")]
        public decimal Units { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }
    }
}
