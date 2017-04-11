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

        /// <summary>
        /// Get a <see cref="List{T}"/> of all current <see cref="Event"/>s.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Event"/>.</returns>
        public RunResult<List<Event>> GetEvents() {
            return Get<List<Event>>("EVENTS_ALL", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of all current <see cref="Event"/>s.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Event"/>.</returns>
        public Task<RunResult<List<Event>>> GetEventsAsync() {
            return GetAsync<List<Event>>("EVENTS_ALL", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of all <see cref="BasicEvent"/>s for a particular site.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="BasicEvent"/>.</returns>
        public RunResult<List<BasicEvent>> GetSiteEvents(string site_name) {
            return Get<List<BasicEvent>>("EVENTS_BYSITE", m_baseparam, site_name);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of all <see cref="BasicEvent"/>s for a particular site.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BasicEvent"/>.</returns>
        public Task<RunResult<List<BasicEvent>>> GetSiteEventsAsync(string site_name) {
            return GetAsync<List<BasicEvent>>("EVENTS_BYSITE", m_baseparam, site_name);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of all <see cref="BasicEvent"/>s for a particular site.
        /// </summary>
        /// <param name="ievent">The <see cref="Event"/>from which the site name will be used.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="BasicEvent"/>.</returns>
        public RunResult<List<BasicEvent>> GetSiteEvents(Event ievent) {
            return GetSiteEvents(ievent.SiteName);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of all <see cref="BasicEvent"/>s for a particular site.
        /// </summary>
        /// <param name="ievent">The <see cref="Event"/>from which the site name will be used.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BasicEvent"/>.</returns>
        public Task<RunResult<List<BasicEvent>>> GetSiteEventsAsync(Event ievent) {
            return GetSiteEventsAsync(ievent.SiteName);
        }

        /// <summary>
        /// Get specific event details in a <see cref="ExtendedEvent"/> object, based on a site and event ID.
        /// </summary>
        /// <param name="site_name">The name of the site the event belongs to.</param>
        /// <param name="event_id">The ID of the event.</param>
        /// <returns>An <see cref="ExtendedEvent"/>.</returns>
        public RunResult<ExtendedEvent> GetEventDetails(string site_name, int event_id) {
            return Get<ExtendedEvent>("EVENTS_BYSPEC", m_baseparam, site_name, event_id.ToString());
        }

        /// <summary>
        /// Get specific event details in a <see cref="ExtendedEvent"/> object, based on a site and event ID.
        /// </summary>
        /// <param name="site_name">The name of the site the event belongs to.</param>
        /// <param name="event_id">The ID of the event.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedEvent"/>.</returns>
        public Task<RunResult<ExtendedEvent>> GetEventDetailsAsync(string site_name, int event_id) {
            return GetAsync<ExtendedEvent>("EVENTS_BYSPEC", m_baseparam, site_name, event_id.ToString());
        }

        /// <summary>
        /// Get specific event details in a <see cref="ExtendedEvent"/> object, based on an <see cref="Event"/>.
        /// </summary>
        /// <param name="ievent">The <see cref="Event"/>from which the site name will be used.</param>
        /// <returns>An <see cref="ExtendedEvent"/>.</returns>
        public RunResult<ExtendedEvent> GetEventDetails(Event ievent) {
            return GetEventDetails(ievent.SiteName, (int)ievent.ID);
        }

        /// <summary>
        /// Get specific event details in a <see cref="ExtendedEvent"/> object, based on an <see cref="Event"/>.
        /// </summary>
        /// <param name="ievent">The <see cref="Event"/>from which the site name will be used.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedEvent"/>.</returns>
        public Task<RunResult<ExtendedEvent>> GetEventDetailsAsync(Event ievent) {
            return GetEventDetailsAsync(ievent.SiteName, (int)ievent.ID);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all university <see cref="Holiday"/>s.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Holiday"/> objects.</returns>
        public RunResult<List<Holiday>> GetUniversityHolidays() {
            return Get<List<Holiday>>("EVENTS_HOLIDAYS", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all university <see cref="Holiday"/>s.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Holiday"/> objects.</returns>
        public Task<RunResult<List<Holiday>>> GetUniversityHolidaysAsync() {
            return GetAsync<List<Holiday>>("EVENTS_HOLIDAYS", m_baseparam);
        }
    }
}
