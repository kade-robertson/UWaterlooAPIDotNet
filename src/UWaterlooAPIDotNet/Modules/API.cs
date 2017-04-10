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
        /// This method returns a <see cref="List{T}"/> of changes made to the API.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Change">, if applicable.</returns>
        public RunResult<List<Change>> GetChangelog() {
            return Get<List<Change>>("API_CHANGELOG");
        }

        /// <summary>
        /// This method returns a <see cref="List{T}"/> of changes made to the API.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Change"/>, if applicable.</returns>
        public Task<RunResult<List<Change>>> GetChangelogAsync() {
            return GetAsync<List<Change>>("API_CHANGELOG");
        }

        /// <summary>
        /// This method returns the version history of the API.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Version">, if applicable.</returns>
        public RunResult<List<Version>> GetVersions() {
            return Get<List<Version>>("API_VERSIONS");
        }

        /// <summary>
        /// This method returns the version history of the API.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Version"/>, if applicable.</returns>
        public Task<RunResult<List<Version>>> GetVersionsAsync() {
            return GetAsync<List<Version>>("API_VERSIONS");
        }

        /// <summary>
        /// This method returns all API endpoint methods available to use.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Method"/>, if applicable.</returns>
        public RunResult<List<Method>> GetMethods() {
            return Get<List<Method>>("API_METHODS");
        }

        /// <summary>
        /// This method returns all API endpoint methods available to use.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Method"/>, if applicable.</returns>
        public Task<RunResult<List<Method>>> GetMethodsAsync() {
            return GetAsync<List<Method>>("API_METHODS");
        }

        /// <summary>
        /// This method returns all API services available to use.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Service"/>, if applicable.</returns>
        public RunResult<List<Service>> GetServices() {
            return Get<List<Service>>("API_SERVICES");
        }

        /// <summary>
        /// This method returns all API services available to use.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Service"/>, if applicable.</returns>
        public Task<RunResult<List<Service>>> GetServicesAsync() {
            return GetAsync<List<Service>>("API_SERVICES");
        }

        /// <summary>
        /// This method returns the user's API usage statistics.
        /// </summary>
        /// <returns>A <see cref="Usage"/> object, if applicable.</returns>
        public RunResult<Usage> GetUsage() {
            return Get<Usage>("API_USAGE", m_baseparam);
        }

        /// <summary>
        /// This method returns the user's API usage statistics.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="Usage"/> object, if applicable.</returns>
        public Task<RunResult<Usage>> GetUsageAsync() {
            return GetAsync<Usage>("API_USAGE", m_baseparam);
        }
    }
}
