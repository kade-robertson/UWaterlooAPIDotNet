using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Server;

namespace UWaterlooAPIDotNet.Modules
{
    public class Server : GenericModule
    {
        public Server(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<TimeData> GetServerTime() {
            return Get<TimeData>("SERVER_TIME");
        }

        public async Task<RunResult<TimeData>> GetServerTimeAsync() {
            return await GetAsync<TimeData>("SERVER_TIME");
        }

        public RunResult<List<ServerCode>> GetServerCodes() {
            return Get<List<ServerCode>>("SERVER_CODES");
        }

        public async Task<RunResult<List<ServerCode>>> GetServerCodesAsync() {
            return await GetAsync<List<ServerCode>>("SERVER_CODES");
        }
    }
}
