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

        public async Task<RunResult<List<Change>>> GetChangelogAsync() {
            return await GetAsync<List<Change>>("API_CHANGELOG").ConfigureAwait(false);
        }

        public RunResult<List<Version>> GetVersions() {
            return Get<List<Version>>("API_VERSIONS");
        }

        public async Task<RunResult<List<Version>>> GetVersionsAsync() {
            return await GetAsync<List<Version>>("API_VERSIONS").ConfigureAwait(false);
        }

        public RunResult<List<Method>> GetMethods() {
            return Get<List<Method>>("API_METHODS");
        }

        public async Task<RunResult<List<Method>>> GetMethodsAsync() {
            return await GetAsync<List<Method>>("API_METHODS").ConfigureAwait(false);
        }

        public RunResult<List<Service>> GetServices() {
            return Get<List<Service>>("API_SERVICES");
        }

        public async Task<RunResult<List<Service>>> GetServicesAsync() {
            return await GetAsync<List<Service>>("API_SERVICES").ConfigureAwait(false);
        }

        public RunResult<Usage> GetUsage() {
            return Get<Usage>("API_USAGE", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<Usage>> GetUsageAsync() {
            return await GetAsync<Usage>("API_USAGE", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }
    }
}
