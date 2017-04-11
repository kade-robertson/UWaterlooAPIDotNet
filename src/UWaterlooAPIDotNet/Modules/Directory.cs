using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Directory;

namespace UWaterlooAPIDotNet.Modules
{
    public class Directory : GenericModule
    {
        public Directory(string apikey, HttpClient client) : base(apikey, client) { }

        /// <summary>
        /// Obtain <see cref="UserInfo"/> for a specific user ID.
        /// </summary>
        /// <param name="userid">The ID of the user to obtain information for.</param>
        /// <returns>A <see cref="UserInfo"/> object.</returns>
        public RunResult<UserInfo> GetUserInfo(string userid) {
            return Get<UserInfo>("DIRECTORY_USERINFO", m_baseparam, userid);
        }

        /// <summary>
        /// Obtain <see cref="UserInfo"/> for a specific user ID.
        /// </summary>
        /// <param name="userid">The ID of the user to obtain information for.</param>
        /// <returns>An awaitable task of a <see cref="UserInfo"/> object.</returns>
        public Task<RunResult<UserInfo>> GetUserInfoAsync(string userid) {
            return GetAsync<UserInfo>("DIRECTORY_USERINFO", m_baseparam, userid);
        }
    }
}
