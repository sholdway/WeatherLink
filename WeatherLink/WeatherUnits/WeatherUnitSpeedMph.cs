using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public class WeatherUnitSpeedMph : WeatherUnitBase
    {   
        public WeatherUnitSpeedMph(double metricValue)
        {
            Unit = "MPH";
            UnitName = "Miles per hour";
            MetricValue = metricValue;
        }

        public override double GetValueFromMetric()
        {
            return MetricValue / 1.609344;
        }

    }
}
