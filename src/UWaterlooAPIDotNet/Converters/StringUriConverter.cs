using System;
using Newtonsoft.Json;

// From StackOverflow answer: http://stackoverflow.com/questions/10259630/serializing-deserializing-system-uri


namespace UWaterlooAPIDotNet.Converters
{
    public class StringUriConverter : JsonConverter 
    {
        public override bool CanConvert(Type objectType) {
            return object.Equals(objectType, typeof(Uri));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            switch (reader.TokenType) {
                case JsonToken.String:
                    return CreateUri((string)reader.Value);
                case JsonToken.Null:
                    return null;
                default:
                    var msg = string.Format("Unable to deserialize Uri from token type {0}", reader.TokenType);
                    throw new InvalidOperationException(msg);
            }
        }

        private static Uri CreateUri(string uriString) {
            Uri uri;
            uriString = uriString.Replace("///", "//");
            if (!Uri.TryCreate(uriString, UriKind.Absolute, out uri))
                if (!Uri.TryCreate(uriString, UriKind.Absolute, out uri))
                    if (!Uri.TryCreate(uriString, UriKind.RelativeOrAbsolute, out uri)) {
                        var msg = string.Format("Unable to determine proper UriKind for Uri {0}", uriString);
                        throw new InvalidOperationException(msg);
                    }
            return uri;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            if (value == null) {
                writer.WriteNull();
                return;
            }
            var uri = value as Uri;
            if (uri != null) {
                writer.WriteValue(uri.OriginalString);
                return;
            }
            var msg = string.Format("Unable to serialize {0} with {1}", value.GetType(), typeof(StringUriConverter));
            throw new InvalidOperationException(msg);
        }

    }
}
