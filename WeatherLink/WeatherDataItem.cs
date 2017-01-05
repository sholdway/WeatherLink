using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public class WeatherDataItem
    {        
        public WeatherDataItem(double temperatureMetric, double windSpeedMetric)
        {
            TemperatureMetric = temperatureMetric;
            WindSpeedMetric = windSpeedMetric;
        }

        public double TemperatureMetric { get; set; }
        public double WindSpeedMetric { get; set; }

    }
}
