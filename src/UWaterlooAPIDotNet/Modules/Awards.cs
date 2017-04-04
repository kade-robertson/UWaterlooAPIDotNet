using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Awards;

namespace UWaterlooAPIDotNet.Modules
{
    public class Awards : GenericModule
    {
        public Awards(string apikey, HttpClient client) : base(apikey, client) { }

        /// <summary>
        /// Obtain a list of all available graduate awards.
        /// </summary>
        /// <returns>A list of Award objects.</returns>
        public RunResult<List<Award>> GetGraduateAwards() {
            return Get<List<Award>>("AWARDS_GRADUATE", m_baseparam);
        }

        /// <summary>
        /// Obtain a list of all available graduate awards.
        /// </summary>
        /// <returns>An awaitable task of a list of Award objects.</returns>
        public Task<RunResult<List<Award>>> GetGraduateAwardsAsync() {
            return GetAsync<List<Award>>("AWARDS_GRADUATE", m_baseparam);
        }

        /// <summary>
        /// Obtain a list of all available undergraduate awards.
        /// </summary>
        /// <returns>A list of Award objects.</returns>
        public RunResult<List<Award>> GetUndergraduateAwards() {
            return Get<List<Award>>("AWARDS_UNDERGRADUATE", m_baseparam);
        }

        /// <summary>
        /// Obtain a list of all available undergraduate awards.
        /// </summary>
        /// <returns>An awaitable task of a list of Award objects.</returns>
        public Task<RunResult<List<Award>>> GetUndergraduateAwardsAsync() {
            return GetAsync<List<Award>>("AWARDS_UNDERGRADUATE", m_baseparam);
        }
    }
}
