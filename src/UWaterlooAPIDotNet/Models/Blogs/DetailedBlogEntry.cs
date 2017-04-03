using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class DetailedBlogEntry 
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        [JsonProperty(PropertyName = "image")]
        public GenericImage Image { get; private set; }

        [JsonProperty(PropertyName = "site_id")]
        public string SiteID { get; private set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }

        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }

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

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }
    }
}
