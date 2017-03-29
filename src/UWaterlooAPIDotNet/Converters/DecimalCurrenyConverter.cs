using Newtonsoft.Json;
using System;
using System.Globalization;

namespace UWaterlooAPIDotNet.Converters
{
    public class DecimalCurrenyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(decimal);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var x = decimal.Zero;
            if (decimal.TryParse(serializer.Deserialize<string>(reader), NumberStyles.Currency, null, out x)) {
                return x;
            }
            return decimal.MinusOne;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            serializer.Serialize(writer, ((decimal)value).ToString("C"));
        }
    }
}
