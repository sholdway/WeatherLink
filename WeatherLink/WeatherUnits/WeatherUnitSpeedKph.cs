using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public class WeatherUnitSpeedKph : WeatherUnitBase
    {   
        public WeatherUnitSpeedKph(double metricValue)
        {
            Unit = "KPH";
            UnitName = "Kilometers per hour";
            MetricValue = metricValue;
        }

        public override double GetValueFromMetric()
        {
            // Metric value is kph so can return that
            return MetricValue;
        }

    }
}
