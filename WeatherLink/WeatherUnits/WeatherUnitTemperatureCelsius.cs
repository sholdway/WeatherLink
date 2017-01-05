using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public class WeatherUnitTemperatureCelsius : WeatherUnitBase
    {   
        public WeatherUnitTemperatureCelsius(double metricValue)
        {
            Unit = "C";
            UnitName = "Celsius";
            MetricValue = metricValue;
        }

        public override double GetValueFromMetric()
        {
            // Metric value is celsius so can return that
            return MetricValue;         
        }

    }
}
