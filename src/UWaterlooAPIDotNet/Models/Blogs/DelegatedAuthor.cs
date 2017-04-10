using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Blogs
{
    public class DelegatedAuthor
    {
        /// <summary>
        /// The URL of the delegated author.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }

        /// <summary>
        /// The full name of the delegated author.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        /// <summary>
        /// A <see cref="Dictionary{TKey, TValue}"/> of various author attributes.
        /// </summary>
        /// <typeparam name="
        [JsonProperty(PropertyName = "attributes")]
        public Dictionary<string, string> Attributes { get; private set; }

        /// <summary>
        /// Purpose is undocumented.
        /// </summary>
        [JsonProperty(PropertyName = "html")]
        public bool HTML { get; private set; }

        /// <summary>
        /// Alternative link if the delegated author does not have their own.
        /// </summary>
        [JsonProperty(PropertyName = "display_url")]
        public Uri DisplayURL { get; private set; }
    }
}
