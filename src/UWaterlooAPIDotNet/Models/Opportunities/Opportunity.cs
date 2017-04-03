using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Opportunities
{
    public class Opportunity : BasicOpportunity
    {
        [JsonProperty(PropertyName = "site")]
        public string SiteID { get; private set; }
    }
}
