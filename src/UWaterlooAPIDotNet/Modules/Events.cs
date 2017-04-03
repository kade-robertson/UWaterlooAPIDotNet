using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Events;

namespace UWaterlooAPIDotNet.Modules
{
    public class Events : GenericModule
    {
        public Events(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<Event>> GetEvents() {
            return Get<List<Event>>("EVENTS_ALL", m_baseparam);
        }

        public Task<RunResult<List<Event>>> GetEventsAsync() {
            return GetAsync<List<Event>>("EVENTS_ALL", m_baseparam);
        }

        public RunResult<List<BasicEvent>> GetSiteEvents(string site_name) {
            return Get<List<BasicEvent>>("EVENTS_BYSITE", m_baseparam, site_name);
        }

        public Task<RunResult<List<BasicEvent>>> GetSiteEventsAsync(string site_name) {
            return GetAsync<List<BasicEvent>>("EVENTS_BYSITE", m_baseparam, site_name);
        }

        public RunResult<List<BasicEvent>> GetSiteEvents(Event ievent) {
            return GetSiteEvents(ievent.SiteName);
        }

        public Task<RunResult<List<BasicEvent>>> GetSiteEventsAsync(Event ievent) {
            return GetSiteEventsAsync(ievent.SiteName);
        }

        public RunResult<ExtendedEvent> GetEventDetails(string site_name, int event_id) {
            return Get<ExtendedEvent>("EVENTS_BYSPEC", m_baseparam, site_name, event_id.ToString());
        }

        public Task<RunResult<ExtendedEvent>> GetEventDetailsAsync(string site_name, int event_id) {
            return GetAsync<ExtendedEvent>("EVENTS_BYSPEC", m_baseparam, site_name, event_id.ToString());
        }

        public RunResult<ExtendedEvent> GetEventDetails(Event ievent) {
            return GetEventDetails(ievent.SiteName, (int)ievent.ID);
        }

        public Task<RunResult<ExtendedEvent>> GetEventDetailsAsync(Event ievent) {
            return GetEventDetailsAsync(ievent.SiteName, (int)ievent.ID);
        }

        public RunResult<List<Holiday>> GetUniversityHolidays() {
            return Get<List<Holiday>>("EVENTS_HOLIDAYS", m_baseparam);
        }

        public Task<RunResult<List<Holiday>>> GetUniversityHolidaysAsync() {
            return GetAsync<List<Holiday>>("EVENTS_HOLIDAYS", m_baseparam);
        }
    }
}
