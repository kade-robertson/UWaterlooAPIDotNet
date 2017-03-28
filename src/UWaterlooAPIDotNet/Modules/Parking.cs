using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Parking;

namespace UWaterlooAPIDotNet.Modules
{
    public class Parking : GenericModule
    {
        public Parking(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<DetailedLot>> GetLotCapacities() {
            return Get<List<DetailedLot>>("PRKNG_WATPARK", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<DetailedLot>>> GetLotCapacitiesAsync() {
            return await GetAsync<List<DetailedLot>>("PRKNG_WATPARK", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<PointOfInterest>> GetMeteredLots() {
            return Get<List<PointOfInterest>>("PRKNG_METERS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<PointOfInterest>>> GetMeteredLotsAsync() {
            return await GetAsync<List<PointOfInterest>>("PRKNG_METERS", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<PointOfInterest>> GetPermitLots() {
            return Get<List<PointOfInterest>>("PRKNG_PERMITS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<PointOfInterest>>> GetPermitLotsAsync() {
            return await GetAsync<List<PointOfInterest>>("PRKNG_PERMITS", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<PointOfInterest>> GetVisitorLots() {
            return Get<List<PointOfInterest>>("PRKNG_VISITORS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<PointOfInterest>>> GetVisitorLotsAsync() {
            return await GetAsync<List<PointOfInterest>>("PRKNG_VISITORS", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<ShortTermLot>> GetShortTermLots() {
            return Get<List<ShortTermLot>>("PRKNG_SHORTTERM", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<ShortTermLot>>> GetShortTermLotsAsync() {
            return await GetAsync<List<ShortTermLot>>("PRKNG_SHORTTERM", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<PointOfInterest>> GetAccessibleLots() {
            return Get<List<PointOfInterest>>("PRKNG_ACCESSIBLE", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<PointOfInterest>>> GetAccessibleLotsAsync() {
            return await GetAsync<List<PointOfInterest>>("PRKNG_ACCESSIBLE", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }

        public RunResult<List<PointOfInterest>> GetMotorcycleLots() {
            return Get<List<PointOfInterest>>("PRKNG_MOTORCYCLE", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<PointOfInterest>>> GetMotorcycleLotsAsync() {
            return await GetAsync<List<PointOfInterest>>("PRKNG_MOTORCYCLE", new StringContent($"?key={m_apikey}")).ConfigureAwait(false);
        }
    }
}
