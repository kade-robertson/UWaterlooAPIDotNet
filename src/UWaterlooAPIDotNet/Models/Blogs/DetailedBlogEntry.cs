using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class DetailedBlogEntry : GenericNews
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        [JsonProperty(PropertyName = "image")]
        public GenericImage Image { get; private set; }

        [JsonProperty(PropertyName = "site_id")]
        public new string SiteID { get; private set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }

        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }
    }
}
