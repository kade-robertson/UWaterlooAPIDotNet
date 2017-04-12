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

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all <see cref="FedEvent"/>s in the system.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="FedEvent"/> objects.</returns>
        public RunResult<List<FedEvent>> GetEventList() {
            return Get<List<FedEvent>>("FEDS_EVENTS", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all <see cref="FedEvent"/>s in the system.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="FedEvent"/> objects.</returns>
        public Task<RunResult<List<FedEvent>>> GetEventListAsync() {
            return GetAsync<List<FedEvent>>("FEDS_EVENTS", m_baseparam);
        }

        /// <summary>
        /// Obtained more detailed event information, based on an event ID.
        /// </summary>
        /// <param name="event_id">The ID of the event.</param>
        /// <returns>A <see cref="FedEventEx"/> object with the data.</returns>
        public RunResult<FedEventEx> GetEventDetails(int event_id) {
            return Get<FedEventEx>("FEDS_EVENTS_BYID", m_baseparam, event_id.ToString());
        }

        /// <summary>
        /// Obtained more detailed event information, based on an event ID.
        /// </summary>
        /// <param name="event_id">The ID of the event.</param>
        /// <returns>An awaitable task of a <see cref="FedEventEx"/> object with the data.</returns>
        public Task<RunResult<FedEventEx>> GetEventDetailsAsync(int event_id) {
            return GetAsync<FedEventEx>("FEDS_EVENTS_BYID", m_baseparam, event_id.ToString());
        }

        /// <summary>
        /// Obtained more detailed event information, based on a <see cref="FedEvent"/>.
        /// </summary>
        /// <param name="fevent">The <see cref="FedEvent"/> object to pull the ID from.</param>
        /// <returns>A <see cref="FedEventEx"/> object with the data.</returns>
        public RunResult<FedEventEx> GetEventDetails(FedEvent fevent) {
            return GetEventDetails(fevent.ID);
        }

        /// <summary>
        /// Obtained more detailed event information, based on a <see cref="FedEvent"/>.
        /// </summary>
        /// <param name="fevent">The <see cref="FedEvent"/> object to pull the ID from.</param>
        /// <returns>An awaitable task of a <see cref="FedEventEx"/> object with the data.</returns>
        public Task<RunResult<FedEventEx>> GetEventListAsync(FedEvent fevent) {
            return GetEventDetailsAsync(fevent.ID);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all official <see cref="FedLocation"/>s at the current time.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="FedLocation"/> objects.</returns>
        public RunResult<List<FedLocation>> GetFedLocations() {
            return Get<List<FedLocation>>("FEDS_LOCATIONS", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all official <see cref="FedLocation"/>s at the current time.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="FedLocation"/> objects.</returns>
        public Task<RunResult<List<FedLocation>>> GetFedLocationsAsync() {
            return GetAsync<List<FedLocation>>("FEDS_LOCATIONS", m_baseparam);
        }
    }
}
