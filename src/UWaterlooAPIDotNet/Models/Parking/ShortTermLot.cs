using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.Parking
{
    public class ShortTermLot : BasicLot 
    {
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; private set; }

        [JsonProperty(PropertyName = "maxstay")]
        public string MaxStay { get; private set; }
    }
}
