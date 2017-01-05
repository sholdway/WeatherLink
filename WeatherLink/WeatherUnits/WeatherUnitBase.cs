using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public abstract class WeatherUnitBase
    {   
        /// <summary>
        /// Unit Key
        /// </summary>
        public string Unit { get; set; }     

        /// <summary>
        /// Unit name
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Unit Value 
        /// </summary>
        public double Value {
            get { return GetValueFromMetric(); }
        }

        /// <summary>
        /// Returns unit value from the metric value
        /// </summary>
        public abstract double GetValueFromMetric();

        /// <summary>
        /// Value in Metric (e.g. Celsius, kph)
        /// </summary>
        public double MetricValue { get; set; }

    }
}
