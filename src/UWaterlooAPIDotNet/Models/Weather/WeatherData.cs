using Newtonsoft.Json;
using NodaTime;
using System;

namespace UWaterlooAPIDotNet.Models.Weather
{
    public class WeatherData
    {
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; private set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; private set; }

        [JsonProperty(PropertyName = "elevation_m")]
        public decimal? Elevation { get; private set; }

        [JsonProperty(PropertyName = "observation_time")]
        private string ObservationTimeString { get; set; }

        [JsonIgnore]
        public ZonedDateTime ObservationTime {
            get {
                var i = LocalDateTime.FromDateTime(DateTime.Parse(ObservationTimeString));
                var o = DateTimeOffset.Parse(ObservationTimeString);
                return i.InZoneLeniently(DateTimeZone.ForOffset(Offset.FromTimeSpan(o.Offset)));
            }
        }

        [JsonProperty(PropertyName = "temperature_current_c")]
        public decimal? CurrentTemperature { get; private set; }

        [JsonProperty(PropertyName = "humidex_c")]
        public decimal? Humidex { get; private set; }

        [JsonProperty(PropertyName = "windchill_c")]
        public decimal? WindChill { get; private set; }

        [JsonProperty(PropertyName = "temperature_24hr_max_c")]
        public decimal? MaxTemperature { get; private set; }

        [JsonProperty(PropertyName = "temperature_24hr_min_c")]
        public decimal? MinTemperature { get; private set; }

        [JsonProperty(PropertyName = "precipitation_15min_mm")]
        public decimal? Precipitation15Minutes { get; private set; }

        [JsonProperty(PropertyName = "precipitation_1hr_mm")]
        public decimal? Precipitation1Hour { get; private set; }

        [JsonProperty(PropertyName = "precipitation_24hr_mm")]
        public decimal? Precipitation24Hour { get; private set; }

        [JsonProperty(PropertyName = "relative_humidity_percent")]
        public decimal? RelativeHumidity { get; private set; }

        [JsonProperty(PropertyName = "dew_point_c")]
        public decimal? DewPoint { get; private set; }

        [JsonProperty(PropertyName = "wind_speed_kph")]
        public decimal? WindSpeed { get; private set; }

        [JsonProperty(PropertyName = "wind_direction")]
        public string WindDirection { get; private set; }

        [JsonProperty(PropertyName = "pressure_kpa")]
        public decimal? Pressure { get; private set; }

        [JsonProperty(PropertyName = "pressure_trend")]
        public string PressureTrend { get; private set; }

        [JsonProperty(PropertyName = "incoming_shortwave_radiation_wm2")]
        public decimal? IncomingSWRadiation { get; private set; }
    }
}
