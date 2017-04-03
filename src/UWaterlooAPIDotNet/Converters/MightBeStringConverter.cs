using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Converters
{
    public class MightBeStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            try {
                return serializer.Deserialize<string>(reader);
            } catch {
                return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            serializer.Serialize(writer, (string)value);
        }
    }
}
