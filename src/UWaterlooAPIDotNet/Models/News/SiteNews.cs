using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.News
{
    public class SiteNews : GenericNews 
    {
        [JsonProperty(PropertyName = "site")]
        public string SiteID { get; private set; }
    }
}
