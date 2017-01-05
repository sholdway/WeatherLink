using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public class WeatherUnitTemperatureFahrenheit : WeatherUnitBase
    {   
        public WeatherUnitTemperatureFahrenheit(double metricValue)
        {
            Unit = "F";
            UnitName = "Fahrenheit";
            MetricValue = metricValue;
        }

        public override double GetValueFromMetric()
        {
            return MetricValue * 1.8 + 32;        
        }

    }
}
