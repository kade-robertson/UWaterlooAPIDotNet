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
            return Get<List<PointOfInterest>>("POI_ATMS", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetATMsAsync() {
            return GetAsync<List<PointOfInterest>>("POI_ATMS", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetGreyhoundStops() {
            return Get<List<PointOfInterest>>("POI_GREYHOUND", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetGreyhoundStopsAsync() {
            return GetAsync<List<PointOfInterest>>("POI_GREYHOUND", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetHelplines() {
            return Get<List<PointOfInterest>>("POI_HELPLINES", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetHelplinesAsync() {
            return GetAsync<List<PointOfInterest>>("POI_HELPLINES", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetLibraries() {
            return Get<List<PointOfInterest>>("POI_LIBRARIES", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetLibrariesAsync() {
            return GetAsync<List<PointOfInterest>>("POI_LIBRARIES", m_baseparam);
        }
    }
}
