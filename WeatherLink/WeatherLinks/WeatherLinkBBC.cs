using System;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace WeatherLink
{
    /// <summary>
    /// Placeholder for BBC weather integration. For demonstration purposes will just return 
    /// fixed data
    /// </summary>
    public class WeatherLinkBBC : WeatherLinkBase
    {
        public WeatherLinkBBC()
        {
            APIKey = "TO DO";
        }

        public override WeatherDataItem GetCurrentConditions(WeatherLocation location)
        {
            WeatherDataItem item = new WeatherDataItem(10.0, 8.0);
            return item;
        }

        public override WeatherLocation FindLocation(string location)
        {
            WeatherLocation weatherLocation = new WeatherLocation();
            weatherLocation.Key = "1";
            weatherLocation.LocalizedName = location;
            return weatherLocation;
        }
    }
}

