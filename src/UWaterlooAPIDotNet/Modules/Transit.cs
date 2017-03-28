﻿using System.Collections.Generic;
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
            return Get<TransitInfo>("TRANSIT_GRT", $"?key={m_apikey}");
        }

        public Task<RunResult<TransitInfo>> GetGRTInfoAsync() {
            return GetAsync<TransitInfo>("TRANSIT_GRT", $"?key={m_apikey}");
        }

        public RunResult<List<StopInfo>> GetGRTStopInfo() {
            return Get<List<StopInfo>>("TRANSIT_GRT_STOPS", $"?key={m_apikey}");
        }

        public Task<RunResult<List<StopInfo>>> GetGRTStopInfoAsync() {
            return GetAsync<List<StopInfo>>("TRANSIT_GRT_STOPS", $"?key={m_apikey}");
        }
    }
}
