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

        [JsonProperty(PropertyName = "wind_direction_degrees")]
        public decimal? WindDirectionDegrees { get; private set; }

        [JsonIgnore]
        public string WindDirection {
            get {
                var w = WindDirectionDegrees % 360;
                var f = (decimal)11.25;
                if (w == null) return "N/A";
                if (w < f     || w > 31*f) return "N";
                if (w >= f    && w < 3*f)  return "NNE";
                if (w >= 3*f  && w < 5*f)  return "NE";
                if (w >= 5*f  && w < 7*f)  return "ENE";
                if (w >= 7*f  && w < 9*f)  return "E";
                if (w >= 9*f  && w < 11*f) return "ESE";
                if (w >= 11*f && w < 13*f) return "SE";
                if (w >= 13*f && w < 15*f) return "SSE";
                if (w >= 15*f && w < 17*f) return "S";
                if (w >= 17*f && w < 19*f) return "SSW";
                if (w >= 19*f && w < 21*f) return "SW";
                if (w >= 21*f && w < 23*f) return "WSW";
                if (w >= 23*f && w < 25*f) return "W";
                if (w >= 25*f && w < 27*f) return "WNW";
                if (w >= 27*f && w < 29*f) return "NW";
                if (w >= 29*f && w < 31*f) return "NNW";
            }
        }

        [JsonProperty(PropertyName = "pressure_kpa")]
        public decimal? Pressure { get; private set; }

        [JsonProperty(PropertyName = "pressure_trend")]
        public string PressureTrend { get; private set; }

        [JsonProperty(PropertyName = "incoming_shortwave_radiation_wm2")]
        public decimal? IncomingSWRadiation { get; private set; }
    }
}
