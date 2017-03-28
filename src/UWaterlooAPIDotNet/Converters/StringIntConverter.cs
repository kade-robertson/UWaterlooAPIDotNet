using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Converters
{
    public class StringIntConverter : JsonConverter 
    {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(int);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var x = 0;
            if (int.TryParse(serializer.Deserialize<string>(reader), out x)) {
                return x;
            }
            return -1;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            serializer.Serialize(writer, value.ToString());
        }
    }
}
