using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Feds;

namespace UWaterlooAPIDotNet.Modules
{
    public class Feds : GenericModule
    {
        public Feds(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<FedEvent>> GetEventList() {
            return Get<List<FedEvent>>("FEDS_EVENTS", m_baseparam);
        }

        public Task<RunResult<List<FedEvent>>> GetEventListAsync() {
            return GetAsync<List<FedEvent>>("FEDS_EVENTS", m_baseparam);
        }

        public RunResult<FedEventEx> GetEventDetails(int event_id) {
            return Get<FedEventEx>("FEDS_EVENTS_BYID", m_baseparam, event_id.ToString());
        }

        public Task<RunResult<FedEventEx>> GetEventDetailsAsync(int event_id) {
            return GetAsync<FedEventEx>("FEDS_EVENTS_BYID", m_baseparam, event_id.ToString());
        }

        public RunResult<FedEventEx> GetEventDetails(FedEvent fevent) {
            return GetEventDetails(fevent.ID);
        }

        public Task<RunResult<FedEventEx>> GetEventListAsync(FedEvent fevent) {
            return GetEventDetailsAsync(fevent.ID);
        }

        public RunResult<List<FedLocation>> GetFedLocations() {
            return Get<List<FedLocation>>("FEDS_LOCATIONS", m_baseparam);
        }

        public Task<RunResult<List<FedLocation>>> GetFedLocationsAsync() {
            return GetAsync<List<FedLocation>>("FEDS_LOCATIONS", m_baseparam);
        }
    }
}
