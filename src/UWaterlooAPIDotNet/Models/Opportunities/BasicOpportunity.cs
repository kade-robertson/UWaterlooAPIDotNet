using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Opportunities
{
    public class BasicOpportunity
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        [JsonProperty(PropertyName = "posted")]
        private string DatePostedString { get; set; }

        [JsonIgnore]
        public ZonedDateTime DatePosted {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(DatePostedString));
                var o = DateTimeOffset.Parse(DatePostedString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "application_deadline")]
        private string ApplicationDeadlineString { get; set; }

        [JsonIgnore]
        public ZonedDateTime ApplicationDeadline {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(ApplicationDeadlineString));
                var o = DateTimeOffset.Parse(ApplicationDeadlineString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "updated")]
        protected string LastUpdatedString { get; set; }

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
