using System;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace WeatherLink
{
    public class WeatherLinkAccu : WeatherLinkBase
    {
        public WeatherLinkAccu()
        {
            APIKey = "uF6DlUYBT5d5IxqzstSLP0hW1lIKhhPc";
        }

        /// <summary>
        /// Calls accu weather api, gets current conditions for specified location.
        /// Call FindLocation before this to retrieve location information
        /// </summary>
        public override WeatherDataItem GetCurrentConditions(WeatherLocation accuLocation)
        {
            string currentConditionsUrl = String.Format(
                "http://dataservice.accuweather.com/currentconditions/v1/{0}?apikey={1}&language=en-gb&details=true",
                    accuLocation.Key, APIKey);
            
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AccuCurrentCondition[]));
            using (WebClient wc = new WebClient())
            {
                // Note to read without affecting the calling thread I would perform the following code:
                // wc.OpenReadCompleted = <Call Back Function>
                // Stream response = wc.OpenReadAsync(new Uri(currentConditionsUrl));
                // So, the application would issue the call, and handle the response (plus the response from other APIs) later.
                // This could enable timeouts/etc, and for the calling application to update when each API responds

                // For the purposes of this demo I have used a simple OpenRead 

                Stream response = wc.OpenRead(currentConditionsUrl);
                AccuCurrentCondition[] currentCondition = (AccuCurrentCondition[])(serializer.ReadObject(response));

                if (currentCondition == null || currentCondition.Length == 0)
                {
                    return null;
                }

                WeatherDataItem item = new WeatherDataItem(
                    currentCondition[0].Temperature.Metric.Value,
                    currentCondition[0].Wind.Speed.Metric.Value
                );

                return item;
            }

        }

        /// <summary>
        /// Calls accu weather api, attempts to find the location given the 
        /// location town name (e.g. Bournemouth)
        /// </summary>
        public override WeatherLocation FindLocation(string location)
        {
            string locationUrl = String.Format(
                "http://dataservice.accuweather.com/locations/v1/search?q={0}&apikey={1}",
                location, APIKey);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(WeatherLocation[]));
            using (WebClient wc = new WebClient())
            {
                Stream response = wc.OpenRead(locationUrl);
                WeatherLocation[] responseJSON = (WeatherLocation[])(serializer.ReadObject(response));
                if (responseJSON.Length > 0)
                {
                    return responseJSON[0];
                }
            }

            return null;
        }
    }


    [DataContract]
    internal class AccuCurrentCondition
    {
        [DataMember]
        public AccuDataItem Temperature { get; set; }

        [DataMember]
        public AccuWind Wind { get; set; }
    }

    [DataContract]
    internal class AccuWind
    {
        [DataMember]
        public AccuDataItem Speed { get; set; }
    }

    [DataContract]
    internal class AccuDataItem
    {
        [DataMember]
        public AccuDataPoint Metric { get; set; }

        [DataMember]
        public AccuDataPoint Imperial { get; set; }
    }

    [DataContract]
    internal class AccuDataPoint
    {
        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public Int32 UnitType { get; set; }
    }
}

