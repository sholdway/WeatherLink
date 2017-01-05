using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink
{
    public static class WeatherUnitFactory
    {   
        public static WeatherUnitBase GetTemperatureUnit(double meanValue, string unitKey)
        {
            switch(unitKey)
            {
                case UnitTypes.TEMPERATURE_CELSIUS:
                    return new WeatherUnitTemperatureCelsius(meanValue);

                case UnitTypes.TEMPERATURE_FAHRENHEIT:
                    return new WeatherUnitTemperatureFahrenheit(meanValue);

                default:
                    return new WeatherUnitTemperatureCelsius(meanValue);
            }
        }

        public static WeatherUnitBase GetSpeedUnit(double meanValue, string unitKey)
        {
            switch (unitKey)
            {
                case UnitTypes.SPEED_KPH:
                    return new WeatherUnitSpeedKph(meanValue);

                case UnitTypes.SPEED_MPH:
                    return new WeatherUnitSpeedMph(meanValue);

                default:
                    return new WeatherUnitSpeedKph(meanValue);
            }
        }        
    }

    public static class UnitTypes
    {
        // Temperature
        public const string TEMPERATURE_CELSIUS = "C";
        public const string TEMPERATURE_FAHRENHEIT = "F";

        // Speed
        public const string SPEED_KPH = "KPH";
        public const string SPEED_MPH = "MPH";
    }
}
