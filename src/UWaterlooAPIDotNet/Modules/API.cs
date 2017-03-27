using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;

namespace UWaterlooAPIDotNet.Modules
{
    public class API
    {
        private string m_apikey;
        private HttpClient m_client;

        public API(string apikey, HttpClient client) {
            m_apikey = apikey;
            m_client = client;
        }

        public RunResult<List<Change>> GetChangelog() {
            try {
                var response = m_client.GetStringAsync(Endpoints.GetEndpoint("API_CHANGELOG")).Result;
                return new RunResult<List<Change>>(response);
            } catch (Exception ex) {
                return new RunResult<List<Change>>(ex);
            }
        }

        public async Task<RunResult<List<Change>>> GetChangelogAsync() {
            try {
                var response = await m_client.GetStringAsync(Endpoints.GetEndpoint("API_CHANGELOG"));
                return new RunResult<List<Change>>(response);
            } catch (Exception ex) {
                return new RunResult<List<Change>>(ex);
            }
        }
    }
}
