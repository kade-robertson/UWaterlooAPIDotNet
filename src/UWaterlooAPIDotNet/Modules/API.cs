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
    }
}
