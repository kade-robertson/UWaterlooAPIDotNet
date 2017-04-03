using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Opportunities
{
    public class DetailedOpportunity : BasicOpportunity
    {
        [JsonProperty(PropertyName = "site_id")]
        public string SiteID { get; private set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; private set; }

        [JsonProperty(PropertyName = "job_id")]
        public string JobID { get; private set; }

        [JsonProperty(PropertyName = "pay")]
        public string PayAmount { get; private set; }

        [JsonProperty(PropertyName = "pay_type")]
        public string PayType { get; private set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; private set; }

        [JsonProperty(PropertyName = "description_raw")]
        public string RawDescription { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; private set; }

        [JsonProperty(PropertyName = "number_of_positions")]
        public string NumberOfPositions { get; private set; }

        [JsonProperty(PropertyName = "application_link")]
        public Uri ApplicationLink { get; private set; }

        [JsonProperty(PropertyName = "reports_to")]
        public string ReportsTo { get; private set; }

        [JsonProperty(PropertyName = "published_by")]
        public string PublishedBy { get; private set; }

        [JsonProperty(PropertyName = "revision_id")]
        public int? RevisionID { get; private set; }
    }
}
