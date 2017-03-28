using Newtonsoft.Json;
using UWaterlooAPIDotNet.Converters;

namespace UWaterlooAPIDotNet.Models.Parking
{
    public class ShortTermLot : PointOfInterest
    {
        [JsonProperty(PropertyName = "capacity")]
        [JsonConverter(typeof(StringIntConverter))]
        public int Capacity { get; private set; }

        [JsonProperty(PropertyName = "maxstay")]
        public string MaxStay { get; private set; }
    }
}
