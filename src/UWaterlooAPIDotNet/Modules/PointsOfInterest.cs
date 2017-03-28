using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.PointsOfInterest;

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

        public RunResult<List<PointOfInterest>> GetPhotospheres() {
            return Get<List<PointOfInterest>>("POI_PHOTOSPHERES", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetPhotospheresAsync() {
            return GetAsync<List<PointOfInterest>>("POI_PHOTOSPHERES", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetDefibrillators() {
            return Get<List<PointOfInterest>>("POI_DEFIBRILLATORS", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetDefibrillatorsAsync() {
            return GetAsync<List<PointOfInterest>>("POI_DEFIBRILLATORS", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetConstructionSites() {
            return Get<List<PointOfInterest>>("POI_CONSTRUCTION", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetConstructionSitesAsync() {
            return GetAsync<List<PointOfInterest>>("POI_CONSTRUCTION", m_baseparam);
        }

        public RunResult<List<PointOfInterest>> GetAccessibleEntrances() {
            return Get<List<PointOfInterest>>("POI_ACCESSIBLE_ENT", m_baseparam);
        }

        public Task<RunResult<List<PointOfInterest>>> GetAccessibleEntrancesAsync() {
            return GetAsync<List<PointOfInterest>>("POI_ACCESSIBLE_ENT", m_baseparam);
        }

        public RunResult<List<VisitorInfo>> GetVistorInfoLocations() {
            return Get<List<VisitorInfo>>("POI_VISITORINFO", m_baseparam);
        }

        public Task<RunResult<List<VisitorInfo>>> GetVistorInfoLocationsAsync() {
            return GetAsync<List<VisitorInfo>>("POI_VISITORINFO", m_baseparam);
        }
    }
}
