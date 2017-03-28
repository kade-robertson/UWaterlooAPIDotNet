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

        public Task<RunResult<TimeData>> GetServerTimeAsync() {
            return GetAsync<TimeData>("SERVER_TIME");
        }

        public RunResult<List<ServerCode>> GetServerCodes() {
            return Get<List<ServerCode>>("SERVER_CODES");
        }

        public Task<RunResult<List<ServerCode>>> GetServerCodesAsync() {
            return GetAsync<List<ServerCode>>("SERVER_CODES");
        }
    }
}
