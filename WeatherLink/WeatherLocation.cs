using System.Runtime.Serialization;

namespace WeatherLink
{
    [DataContract]
    public class WeatherLocation
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string LocalizedName { get; set; }
    }

}
