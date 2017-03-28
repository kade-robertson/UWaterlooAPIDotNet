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
            return Get<List<DetailedLot>>("PRKNG_WATPARK", $"?key={m_apikey}");
        }

        public Task<RunResult<List<DetailedLot>>> GetLotCapacitiesAsync() {
            return GetAsync<List<DetailedLot>>("PRKNG_WATPARK", $"?key={m_apikey}");
        }

        public RunResult<List<PointOfInterest>> GetMeteredLots() {
            return Get<List<PointOfInterest>>("PRKNG_METERS", $"?key={m_apikey}");
        }

        public Task<RunResult<List<PointOfInterest>>> GetMeteredLotsAsync() {
            return GetAsync<List<PointOfInterest>>("PRKNG_METERS", $"?key={m_apikey}");
        }

        public RunResult<List<PointOfInterest>> GetPermitLots() {
            return Get<List<PointOfInterest>>("PRKNG_PERMITS", $"?key={m_apikey}");
        }

        public Task<RunResult<List<PointOfInterest>>> GetPermitLotsAsync() {
            return GetAsync<List<PointOfInterest>>("PRKNG_PERMITS", $"?key={m_apikey}");
        }

        public RunResult<List<PointOfInterest>> GetVisitorLots() {
            return Get<List<PointOfInterest>>("PRKNG_VISITORS", $"?key={m_apikey}");
        }

        public Task<RunResult<List<PointOfInterest>>> GetVisitorLotsAsync() {
            return GetAsync<List<PointOfInterest>>("PRKNG_VISITORS", $"?key={m_apikey}");
        }

        public RunResult<List<ShortTermLot>> GetShortTermLots() {
            return Get<List<ShortTermLot>>("PRKNG_SHORTTERM", $"?key={m_apikey}");
        }

        public Task<RunResult<List<ShortTermLot>>> GetShortTermLotsAsync() {
            return GetAsync<List<ShortTermLot>>("PRKNG_SHORTTERM", $"?key={m_apikey}");
        }

        public RunResult<List<PointOfInterest>> GetAccessibleLots() {
            return Get<List<PointOfInterest>>("PRKNG_ACCESSIBLE", $"?key={m_apikey}");
        }

        public Task<RunResult<List<PointOfInterest>>> GetAccessibleLotsAsync() {
            return GetAsync<List<PointOfInterest>>("PRKNG_ACCESSIBLE", $"?key={m_apikey}");
        }

        public RunResult<List<PointOfInterest>> GetMotorcycleLots() {
            return Get<List<PointOfInterest>>("PRKNG_MOTORCYCLE", $"?key={m_apikey}");
        }

        public Task<RunResult<List<PointOfInterest>>> GetMotorcycleLotsAsync() {
            return GetAsync<List<PointOfInterest>>("PRKNG_MOTORCYCLE", $"?key={m_apikey}");
        }
    }
}
