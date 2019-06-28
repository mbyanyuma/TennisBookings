﻿
namespace TennisBookings.Web.Services
{
    public class WeatherForecaster : IWeatherForecaster
    {
        public WeatherResult GetCurrentWeather()
        {
            // Pretend we call out to a remote 3rd party API here to get the real forecast!
            

            return new WeatherResult
            {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}