using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.API;

namespace UWaterlooAPIDotNet.Modules
{
    public class API : GenericModule
    {
        public API(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<Change>> GetChangelog() {
            return Get<List<Change>>("API_CHANGELOG");
        }

        public Task<RunResult<List<Change>>> GetChangelogAsync() {
            return GetAsync<List<Change>>("API_CHANGELOG");
        }

        public RunResult<List<Version>> GetVersions() {
            return Get<List<Version>>("API_VERSIONS");
        }

        public Task<RunResult<List<Version>>> GetVersionsAsync() {
            return GetAsync<List<Version>>("API_VERSIONS");
        }

        public RunResult<List<Method>> GetMethods() {
            return Get<List<Method>>("API_METHODS");
        }

        public Task<RunResult<List<Method>>> GetMethodsAsync() {
            return GetAsync<List<Method>>("API_METHODS");
        }

        public RunResult<List<Service>> GetServices() {
            return Get<List<Service>>("API_SERVICES");
        }

        public Task<RunResult<List<Service>>> GetServicesAsync() {
            return GetAsync<List<Service>>("API_SERVICES");
        }

        public RunResult<Usage> GetUsage() {
            return Get<Usage>("API_USAGE", m_baseparam);
        }

        public Task<RunResult<Usage>> GetUsageAsync() {
            return GetAsync<Usage>("API_USAGE", m_baseparam);
        }
    }
}
