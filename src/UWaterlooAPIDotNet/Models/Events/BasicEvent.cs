using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Events
{
    public class BasicEvent
    {
        /// <summary>
        /// The ID of the event.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of <see cref="EventTimes"/> for the event.
        /// </summary>
        [JsonProperty(PropertyName = "times")]
        public List<EventTimes> Times { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of types the event falls under.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public List<string> Type { get; private set; }

        /// <summary>
        /// A link to the event's website.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }

        [JsonProperty(PropertyName = "updated")]
        private string UpdatedTimeString { get; set; }

        /// <summary>
        /// The time at which the event details were most recently updates.
        /// </summary>
        [JsonIgnore]
        public ZonedDateTime UpdatedTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(UpdatedTimeString));
                var o = DateTimeOffset.Parse(UpdatedTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }
    }
}
