using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Directory;

namespace UWaterlooAPIDotNet.Modules
{
    public class Directory : GenericModule
    {
        public Directory(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<UserInfo> GetUserInfo(string userid) {
            return Get<UserInfo>("DIRECTORY_USERINFO", new StringContent($"?key={m_apikey}"), userid);
        }

        public async Task<RunResult<UserInfo>> GetUserInfoAsync(string userid) {
            return await GetAsync<UserInfo>("DIRECTORY_USERINFO", new StringContent($"?key={m_apikey}"), userid).ConfigureAwait(false);
        }
    }
}
