using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Feds
{
    public class FedEvent
    {
        /// <summary>
        /// The ID of the event.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int ID { get; private set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Name { get; private set; }

        /// <summary>
        /// The name of the location where the event is taking place.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        [JsonProperty(PropertyName = "start")]
        private string StartTimeString { get; set; }

        /// <summary>
        /// The date & time at which the event starts.
        /// </summary>
        [JsonIgnore]
        public ZonedDateTime StartTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(StartTimeString));
                var o = DateTimeOffset.Parse(StartTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "end")]
        private string EndTimeString { get; set; }

        /// <summary>
        /// The date & time at which the event ends.
        /// </summary>
        [JsonIgnore]
        public ZonedDateTime EndTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(EndTimeString));
                var o = DateTimeOffset.Parse(EndTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        /// <summary>
        /// The <see cref="List{T}"/> of categories the event falls under.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public List<string> Categories { get; private set; }

        [JsonProperty(PropertyName = "end")]
        private string UpdatedTimeString { get; set; }

        /// <summary>
        /// The last time event information was updated.
        /// </summary>
        [JsonIgnore]
        public ZonedDateTime LastUpdated {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(UpdatedTimeString));
                var o = DateTimeOffset.Parse(UpdatedTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        /// <summary>
        /// A link to the event page.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public Uri URL { get; private set; }
    }
}
