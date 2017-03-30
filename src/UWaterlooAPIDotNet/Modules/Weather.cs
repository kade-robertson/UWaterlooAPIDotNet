using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Weather;

namespace UWaterlooAPIDotNet.Modules
{
    public class Weather : GenericModule
    {
        public Weather(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<WeatherData> GetWeatherData() {
            return Get<WeatherData>("WEATHER_CURRENT");
        }

        public Task<RunResult<WeatherData>> GetWeatherDataAsync() {
            return GetAsync<WeatherData>("WEATHER_CURRENT");
        }
    }
}
