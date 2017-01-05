using System.Collections.Generic;
using System.Linq;

namespace WeatherLink
{
    public class WeatherDataItemCollection: List<WeatherDataItem>
    {        
        /// <summary>
        /// Mean Temperature (metric)
        /// </summary>
        public double MeanTemperature()
        {
            return this.Average(i => i.TemperatureMetric);
        }

        /// <summary>
        /// Mean Wind speed (metric)
        /// </summary>
        public double MeanWindSpeed()
        {
            return this.Average(i => i.WindSpeedMetric);
        }

        /// <summary>
        /// Mean Temperature (in the specified unit)
        /// </summary>
        public double MeanTemperature(string unitKey)
        {
            double meanTemperature = MeanTemperature();
            WeatherUnitBase unit = WeatherUnitFactory.GetTemperatureUnit(meanTemperature, unitKey);
            return unit.GetValueFromMetric();
        }

        /// <summary>
        /// Mean Wind Speed (in the specified unit)
        /// </summary>
        public double MeanWindSpeed(string unitKey)
        {
            double meanWindSpeed = MeanWindSpeed();
            WeatherUnitBase unit = WeatherUnitFactory.GetSpeedUnit(meanWindSpeed, unitKey);
            return unit.GetValueFromMetric();
        }
    }
}
