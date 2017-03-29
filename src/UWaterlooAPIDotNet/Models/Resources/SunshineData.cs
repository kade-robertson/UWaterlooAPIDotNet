using Newtonsoft.Json;
using UWaterlooAPIDotNet.Converters;

namespace UWaterlooAPIDotNet.Models.Resources
{
    public class SunshineData 
    {
        [JsonProperty(PropertyName = "employer")]
        public string Employer { get; private set; }

        [JsonProperty(PropertyName = "surname")]
        public string LastName { get; private set; }

        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; private set; }

        [JsonProperty(PropertyName = "position")]
        public string Lecturer { get; private set; }

        [JsonProperty(PropertyName = "salary_paid")]
        [JsonConverter(typeof(DecimalCurrenyConverter))]
        public decimal SalaryPaid { get; private set; }

        [JsonProperty(PropertyName = "taxable_benefits")]
        [JsonConverter(typeof(DecimalCurrenyConverter))]
        public decimal TaxableBenefits { get; private set; }
    }
}
