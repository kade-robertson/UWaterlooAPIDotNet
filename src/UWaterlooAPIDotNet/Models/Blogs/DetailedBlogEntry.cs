using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class DetailedBlogEntry : GenericNews
    {
        /// <summary>
        /// The full body of the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// The full body of the blog entry, with HTML remaining.
        /// </summary>
        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        /// <summary>
        /// The <see cref="List{T}"/> of targeted audiences by the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        /// <summary>
        /// The <see cref="GenericImage"/> used in the blog entry.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public GenericImage Image { get; private set; }

        /// <summary>
        /// The ID of the site which the blog entry belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public new string SiteID { get; private set; }

        /// <summary>
        /// The name of the site which the blog entry belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }

        /// <summary>
        /// The revision ID of the blog entry in its' current state.
        /// </summary>
        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }
    }
}
