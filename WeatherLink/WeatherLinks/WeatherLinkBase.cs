namespace WeatherLink
{
    /// <summary>
    /// Base class for Weather API Links
    /// </summary>
    public abstract class WeatherLinkBase
    {
        /// <summary>
        /// API Key
        /// </summary>
        protected string APIKey { get; set; }

        /// <summary>
        /// Calls weather api, attempts to find the location given the 
        /// location town name (e.g. Bournemouth)
        /// </summary>
        public abstract WeatherLocation FindLocation(string location);

        /// <summary>
        /// Gets current conditions for specified location.
        /// Call FindLocation before this to retrieve location information
        /// </summary>
        public abstract WeatherDataItem GetCurrentConditions(WeatherLocation location);
    }

}
