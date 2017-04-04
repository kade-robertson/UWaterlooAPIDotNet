using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Awards
{
    public class Award
    {
        /// <summary>
        /// The award ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        /// <summary>
        /// The full name of the award.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        /// <summary>
        /// Indicates whether the award is actively being given out.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// The monetary value of the award.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// The type(s) the award falls under.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        /// <summary>
        /// A description for the award.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Citizenship requirements to be eligible for the award.
        /// </summary>
        [JsonProperty(PropertyName = "citizenship")]
        public List<string> Citizenship { get; private set; }

        /// <summary>
        /// The academic programs which are eligible for the award.
        /// </summary>
        [JsonProperty(PropertyName = "programs")]
        public List<string> Programs { get; private set; }

        /// <summary>
        /// Provides more detailed information about the application process.
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public ApplicationInfo ApplicationInfo { get; private set; }

        /// <summary>
        /// Provides more information about the deadlines for applying for the award.
        /// </summary>
        [JsonProperty(PropertyName = "deadlines")]
        public AwardDeadlines Deadlines { get; private set; }

        /// <summary>
        /// A list of links that provide more information on the award.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public List<string> Links { get; private set; }

        /// <summary>
        /// Contact information regarding the award and applications.
        /// </summary>
        [JsonProperty(PropertyName = "contact")]
        public string ContactInfo { get; private set; }

        /// <summary>
        /// The revision ID of the award description.
        /// </summary>
        [JsonProperty(PropertyName = "vid")]
        public int? RevisionID { get; private set; }

        /// <summary>
        /// A link to the award page.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }
    }
}
