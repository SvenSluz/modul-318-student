namespace SwissTransport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Stations
    {
        [JsonProperty("stations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Station> StationList { get; set; }
    }
}