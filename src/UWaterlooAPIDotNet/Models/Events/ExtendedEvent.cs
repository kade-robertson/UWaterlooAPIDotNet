using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class ExtendedEvent : Event
    {
        /// <summary>
        /// A description for the event.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// The raw description of the event (with HTML).
        /// </summary>
        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        /// <summary>
        /// The cost of the event.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of targeted audiences for the event.
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of tags associated with the event.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; private set; }

        /// <summary>
        /// The <see cref="EventWebsite"/> for the event.
        /// </summary>
        [JsonProperty(PropertyName = "website")]
        public EventWebsite Website { get; private set; }

        /// <summary>
        /// The <see cref="EventWebsite"/> for the host of the event.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public EventWebsite Host { get; private set; }

        /// <summary>
        /// A <see cref="GenericImage"/> from the event description.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public GenericImage Image { get; private set; }

        /// <summary>
        /// The <see cref="GenericLocation"/> where the event is taking place.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public GenericLocation Location { get; private set; }

        /// <summary>
        /// The ID of the revision to this event.
        /// </summary>
        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }

        /// <summary>
        /// A linkt to the calendar entry for the event.
        /// </summary>
        [JsonProperty(PropertyName = "link_calendar")]
        public Uri CalendarLink { get; private set; }
    }
}
