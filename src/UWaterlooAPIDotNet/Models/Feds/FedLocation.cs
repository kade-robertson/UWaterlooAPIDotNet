using Newtonsoft.Json;
using UWaterlooAPIDotNet.Models.FoodServices;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedLocation : ExtendedOutlet
    {
        /// <summary>
        /// Indicates whether the location is currently open.
        /// </summary>
        [JsonProperty(PropertyName = "is_open_now")]
        public bool IsCurrentlyOpen { get; private set; }

        /// <summary>
        /// Indicates whether the location is open 24 hours.
        /// </summary>
        [JsonProperty(PropertyName = "is_24hrs")]
        public bool Is24Hours { get; private set; }

        /// <summary>
        /// Additional info for the Fed location.
        /// </summary>
        [JsonProperty(PropertyName = "additional")]
        public FedAdditionalInfo AdditionalInfo { get; private set; }
    }
}
