using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Opportunities;

namespace UWaterlooAPIDotNet.Modules
{
    public class Opportunities : GenericModule 
    {
        public Opportunities(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<Opportunity>> GetAllOpportunities() {
            return Get<List<Opportunity>>("OPPORTUNITIES_ALL", m_baseparam);
        }

        public Task<RunResult<List<Opportunity>>> GetAllOpportunitiesAsync() {
            return GetAsync<List<Opportunity>>("OPPORTUNITIES_ALL", m_baseparam);
        }

        public RunResult<List<Opportunity>> GetOpportunities(string site_id) {
            return Get<List<Opportunity>>("OPPORTUNITIES_BYSITE", m_baseparam, site_id);
        }

        public Task<RunResult<List<Opportunity>>> GetOpportunitiesAsync(string site_id) {
            return GetAsync<List<Opportunity>>("OPPORTUNITIES_BYSITE", m_baseparam, site_id);
        }

        public RunResult<DetailedOpportunity> GetOpportunityDetails(string site_id, int post_id) {
            return Get<DetailedOpportunity>("OPPORTUNITIES_BYSPEC", m_baseparam, site_id, post_id.ToString());
        }

        public Task<RunResult<DetailedOpportunity>> GetOpportunityDetailsAsync(string site_id, int post_id) {
            return GetAsync<DetailedOpportunity>("OPPORTUNITIES_BYSPEC", m_baseparam, site_id, post_id.ToString());
        }

        public RunResult<DetailedOpportunity> GetOpportunityDetails(string site_id, BasicOpportunity opportunity) {
            return GetOpportunityDetails(site_id, (int)opportunity.ID);
        }

        public Task<RunResult<DetailedOpportunity>> GetOpportunityDetailsAsync(string site_id, BasicOpportunity opportunity) {
            return GetOpportunityDetailsAsync(site_id, (int)opportunity.ID);
        }

        public RunResult<DetailedOpportunity> GetOpportunityDetails(Opportunity opportunity) {
            return GetOpportunityDetails(opportunity.SiteID, (int)opportunity.ID);
        }

        public Task<RunResult<DetailedOpportunity>> GetOpportunityDetailsAsync(Opportunity opportunity) {
            return GetOpportunityDetailsAsync(opportunity.SiteID, (int)opportunity.ID);
        }
    }
}
