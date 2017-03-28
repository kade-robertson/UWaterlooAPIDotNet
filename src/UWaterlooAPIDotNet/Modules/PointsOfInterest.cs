using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;

namespace UWaterlooAPIDotNet.Modules
{
    public class PointsOfInterest : GenericModule
    {
        public PointsOfInterest(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<PointOfInterest>> GetATMs() {
            return Get<List<PointOfInterest>>("POI_ATMS", new StringContent($"?key={m_apikey}"));
        }

        public Task<RunResult<List<PointOfInterest>>> GetATMsAsync() {
            return GetAsync<List<PointOfInterest>>("POI_ATMS", new StringContent($"?key={m_apikey}"));
        }
    }
}
