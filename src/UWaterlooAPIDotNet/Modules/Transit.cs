using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Transit;

namespace UWaterlooAPIDotNet.Modules
{
    public class Transit : GenericModule
    {
        public Transit(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<TransitInfo> GetGRTInfo() {
            return Get<TransitInfo>("TRANSIT_GRT", m_baseparam);
        }

        public Task<RunResult<TransitInfo>> GetGRTInfoAsync() {
            return GetAsync<TransitInfo>("TRANSIT_GRT", m_baseparam);
        }

        public RunResult<List<StopInfo>> GetGRTStopInfo() {
            return Get<List<StopInfo>>("TRANSIT_GRT_STOPS", m_baseparam);
        }

        public Task<RunResult<List<StopInfo>>> GetGRTStopInfoAsync() {
            return GetAsync<List<StopInfo>>("TRANSIT_GRT_STOPS", m_baseparam);
        }
    }
}
