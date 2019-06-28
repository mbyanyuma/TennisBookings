using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisBookings.Web.Services
{
    public class AmazingWeatherForecaster : IWeatherForecaster
    {
        public WeatherResult GetCurrentWeather()
        {
            //call some king of third party api to get real time weather data

            //in the mean-time:

            return new WeatherResult()
            {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}
