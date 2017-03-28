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
            return await GetAsync<List<DetailedLot>>("PRKNG_WATPARK", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<BasicLot>> GetMeteredLots() {
            return Get<List<BasicLot>>("PRKNG_METERS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<BasicLot>>> GetMeteredLotsAsync() {
            return await GetAsync<List<BasicLot>>("PRKNG_METERS", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<BasicLot>> GetPermitLots() {
            return Get<List<BasicLot>>("PRKNG_PERMITS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<BasicLot>>> GetPermitLotsAsync() {
            return await GetAsync<List<BasicLot>>("PRKNG_PERMITS", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<BasicLot>> GetVisitorLots() {
            return Get<List<BasicLot>>("PRKNG_VISITORS", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<BasicLot>>> GetVisitorLotsAsync() {
            return await GetAsync<List<BasicLot>>("PRKNG_VISITORS", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<ShortTermLot>> GetShortTermLots() {
            return Get<List<ShortTermLot>>("PRKNG_SHORTTERM", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<ShortTermLot>>> GetShortTermLotsAsync() {
            return await GetAsync<List<ShortTermLot>>("PRKNG_SHORTTERM", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<BasicLot>> GetAccessibleLots() {
            return Get<List<BasicLot>>("PRKNG_ACCESSIBLE", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<BasicLot>>> GetAccessibleLotsAsync() {
            return await GetAsync<List<BasicLot>>("PRKNG_ACCESSIBLE", new StringContent($"?key={m_apikey}"));
        }

        public RunResult<List<BasicLot>> GetMotorcycleLots() {
            return Get<List<BasicLot>>("PRKNG_MOTORCYCLE", new StringContent($"?key={m_apikey}"));
        }

        public async Task<RunResult<List<BasicLot>>> GetMotorcycleLotsAsync() {
            return await GetAsync<List<BasicLot>>("PRKNG_MOTORCYCLE", new StringContent($"?key={m_apikey}"));
        }
    }
}
