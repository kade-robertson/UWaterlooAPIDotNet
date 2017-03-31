using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Resources
{
    public class TutorData
    {
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        [JsonProperty(PropertyName = "catalog_number")]
        public string CatalogNumber { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "tutors_count")]
        public int? Tutors { get; private set; }

        [JsonProperty(PropertyName = "contact_url")]
        public Uri ContactURL { get; private set; }
    }
}
