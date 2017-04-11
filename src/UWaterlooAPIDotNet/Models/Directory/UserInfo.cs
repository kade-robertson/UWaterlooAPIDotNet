using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace UWaterlooAPIDotNet.Models.Directory
{
    public class UserInfo
    {
        /// <summary>
        /// The user's full name.
        /// </summary>
        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; private set; }

        /// <summary>
        /// The user's given name.
        /// </summary>
        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; private set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; private set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserID { get; private set; }

        /// <summary>
        /// The department the user belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "department")]
        public string Department { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of the user's common name(s).
        /// </summary>
        [JsonProperty(PropertyName = "common_names")]
        public List<string> CommonNames { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of the user's email address(es).
        /// </summary>
        [JsonProperty(PropertyName = "email_addresses")]
        public List<string> EmailAddresses { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of the office(s) the user can be found in.
        /// </summary>
        [JsonProperty(PropertyName = "offices")]
        public List<string> Offices { get; private set; }

        /// <summary>
        /// A <see cref="List{T}"/> of the user's telephone number(s).
        /// </summary>
        [JsonProperty(PropertyName = "telephone_numbers")]
        public List<string> TelephoneNumbers { get; private set; }

        /// <summary>
        /// A link to the user's homepage (if applicable).
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public Uri Homepage { get; private set; }
    }
}
