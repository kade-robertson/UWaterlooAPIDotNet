using Newtonsoft.Json;
using NodaTime;
using System;
using System.Collections.Generic;
using UWaterlooAPIDotNet.Converters;
using UWaterlooAPIDotNet.Models.FoodServices;

namespace UWaterlooAPIDotNet.Models.Services
{
    public class SiteService
    {
        [JsonProperty(PropertyName = "id")]
        public int? ID { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; private set; }

        [JsonProperty(PropertyName = "is_open_now")]
        public bool IsOpenNow { get; private set; }

        [JsonProperty(PropertyName = "contact_information")]
        public string ContactInformation { get; private set; }

        [JsonProperty(PropertyName = "notice")]
        public string Notice { get; private set; }

        [JsonProperty(PropertyName = "services_available.")]
        public List<string> ServicesAvailable { get; private set; }

        [JsonProperty(PropertyName = "request_info")]
        public RequestInfo RequestInfo { get; private set; }

        [JsonProperty(PropertyName = "opening_hours")]
        public OpeningHours OpeningHours { get; private set; }

        [JsonProperty(PropertyName = "special_hours")]
        public List<SpecialHour> SpecialHours { get; private set; }

        [JsonProperty(PropertyName = "dates_closed")]
        public List<DateTime> DatesClosed { get; private set; }

        [JsonProperty(PropertyName = "location")]
        public GenericLocation Location { get; private set; }

        [JsonProperty(PropertyName = "category")]
        public List<string> Categories { get; private set; }

        [JsonProperty(PropertyName = "audience")]
        public List<string> Audience { get; private set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }

        [JsonProperty(PropertyName = "site_id")]
        public string SiteID { get; private set; }

        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }

        [JsonProperty(PropertyName = "additional")]
        [JsonConverter(typeof(MightBeStringConverter))]
        public string AdditionalInfo { get; private set; }

        [JsonProperty(PropertyName = "link")]
        public Uri Link { get; private set; }

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
    }
}
