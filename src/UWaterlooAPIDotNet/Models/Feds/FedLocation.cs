using Newtonsoft.Json;
using UWaterlooAPIDotNet.Models.FoodServices;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedLocation : ExtendedOutlet
    {
        [JsonProperty(PropertyName = "is_open_now")]
        public bool IsCurrentlyOpen { get; private set; }

        [JsonProperty(PropertyName = "is_24hrs")]
        public bool Is24Hours { get; private set; }

        [JsonProperty(PropertyName = "additional")]
        public FedAdditionalInfo AdditionalInfo { get; private set; }
    }
}
