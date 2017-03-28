using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Directory
{
    public class UserInfo
    {

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; private set; }

        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; private set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; private set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserID { get; private set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; private set; }

        [JsonProperty(PropertyName = "common_names")]
        public List<string> CommonNames { get; private set; }

        [JsonProperty(PropertyName = "email_addresses")]
        public List<string> EmailAddresses { get; private set; }

        [JsonProperty(PropertyName = "offices")]
        public List<string> Offices { get; private set; }

        [JsonProperty(PropertyName = "telephone_numbers")]
        public List<string> TelephoneNumbers { get; private set; }

        [JsonProperty(PropertyName = "homepage")]
        public Uri Homepage { get; private set; }
    }
}
