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

        /// <summary>
        /// This method returns a list of changes made to the API.
        /// </summary>
        /// <returns>A list of Change objects.</returns>
        public RunResult<List<Change>> GetChangelog() {
            return Get<List<Change>>("API_CHANGELOG");
        }

        /// <summary>
        /// This method returns a list of changes made to the API.
        /// </summary>
        /// <returns>An awaitable task of a list of Change objects.</returns>
        public Task<RunResult<List<Change>>> GetChangelogAsync() {
            return GetAsync<List<Change>>("API_CHANGELOG");
        }

        /// <summary>
        /// This method returns the version history of the API.
        /// </summary>
        /// <returns>A list of Version objects.</returns>
        public RunResult<List<Version>> GetVersions() {
            return Get<List<Version>>("API_VERSIONS");
        }

        /// <summary>
        /// This method returns the version history of the API.
        /// </summary>
        /// <returns>An awaitable task of a list of Version objects.</returns>
        public Task<RunResult<List<Version>>> GetVersionsAsync() {
            return GetAsync<List<Version>>("API_VERSIONS");
        }

        /// <summary>
        /// This method returns all API endpoint methods available to use.
        /// </summary>
        /// <returns>A list of Method objects.</returns>
        public RunResult<List<Method>> GetMethods() {
            return Get<List<Method>>("API_METHODS");
        }

        /// <summary>
        /// This method returns all API endpoint methods available to use.
        /// </summary>
        /// <returns>An awaitable task of a list of Method objects.</returns>
        public Task<RunResult<List<Method>>> GetMethodsAsync() {
            return GetAsync<List<Method>>("API_METHODS");
        }

        /// <summary>
        /// This method returns all API services available to use.
        /// </summary>
        /// <returns>A list of Service objects.</returns>
        public RunResult<List<Service>> GetServices() {
            return Get<List<Service>>("API_SERVICES");
        }

        /// <summary>
        /// This method returns all API services available to use.
        /// </summary>
        /// <returns>An awaitable task of a list of Service objects.</returns>
        public Task<RunResult<List<Service>>> GetServicesAsync() {
            return GetAsync<List<Service>>("API_SERVICES");
        }

        /// <summary>
        /// This method returns the user's API usage statistics.
        /// </summary>
        /// <returns>A Usage object.</returns>
        public RunResult<Usage> GetUsage() {
            return Get<Usage>("API_USAGE", m_baseparam);
        }

        /// <summary>
        /// This method returns the user's API usage statistics.
        /// </summary>
        /// <returns>An awaitable task of a Usage object.</returns>
        public Task<RunResult<Usage>> GetUsageAsync() {
            return GetAsync<Usage>("API_USAGE", m_baseparam);
        }
    }
}
