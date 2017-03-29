using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class TermListing
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
    }
}
