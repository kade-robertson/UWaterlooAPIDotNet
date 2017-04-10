using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class BlogEntry
    {
        /// <summary>
        /// The ID of the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        /// <summary>
        /// The title of the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        /// <summary>
        /// A short teaser of the blog contents.
        /// </summary>
        [JsonProperty(PropertyName = "teaser")]
        public string Teaser { get; private set; }

        /// <summary>
        /// A short teaser of the blog contents, with HTML styling.
        /// </summary>
        [JsonProperty(PropertyName = "teaser_raw")]
        public string RawTeaser { get; private set; }

        /// <summary>
        /// The author of the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Author { get; private set; }

        /// <summary>
        /// The <see cref="Blogs.DelegatedAuthor"/>  of the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "delegated_author")]
        public DelegatedAuthor DelegatedAuthor { get; private set; }

        /// <summary>
        /// The link to view the blog entry in a browser.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }

        /// <summary>
        /// The date at which the blog entry was published, in university local time (EST/EDT).
        /// </summary>
        [JsonProperty(PropertyName = "published")]
        public DateTime DatePublished { get; private set; }

        [JsonProperty(PropertyName = "updated")]
        private string LastUpdatedString { get; set; }

        /// <summary>
        /// The last time the blog entry was updated, with the appropriate time zone information.
        /// </summary>
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
