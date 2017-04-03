using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Services;

namespace UWaterlooAPIDotNet.Modules
{
    public class Services : GenericModule
    {
        public Services(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<SiteService>> GetChangelog(string site_id) {
            return Get<List<SiteService>>("SERVICES_BYSITE", m_baseparam, site_id);
        }

        public Task<RunResult<List<SiteService>>> GetChangelogAsync(string site_id) {
            return GetAsync<List<SiteService>>("SERVICES_BYSITE", m_baseparam, site_id);
        }
    }
}
