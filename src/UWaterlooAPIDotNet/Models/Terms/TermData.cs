using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Terms
{
    public class TermData
    {
        [JsonProperty(PropertyName = "current_term")]
        public int? CurrentTerm { get; private set; }

        [JsonProperty(PropertyName = "previous_term")]
        public int? PreviousTerm { get; private set; }

        [JsonProperty(PropertyName = "next_term")]
        public int? NextTerm { get; private set; }

        [JsonProperty(PropertyName = "listings")]
        public Dictionary<string, List<TermListing>> Listings { get; private set; }

        public List<TermListing> ListingForYear(int year) {
            return Listings[year.ToString()];
        }
    }
}
