using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class BlogEntry
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "teaser")]
        public string Teaser { get; private set; }

        [JsonProperty(PropertyName = "teaser_raw")]
        public string RawTeaser { get; private set; }

        [JsonProperty(PropertyName = "publisher")]
        public string Author { get; private set; }

        [JsonProperty(PropertyName = "delegated_author")]
        public DelegatedAuthor DelegatedAuthor { get; private set; }

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }

        [JsonProperty(PropertyName = "published")]
        public DateTime DatePublished { get; private set; }

        [JsonProperty(PropertyName = "updated")]
        private string LastUpdatedString { get; set; }

        [JsonIgnore]
        public ZonedDateTime LastUpdated {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(LastUpdatedString));
                var o = DateTimeOffset.Parse(LastUpdatedString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }
    }
}
