namespace SwissTransport.Models
{
    using Newtonsoft.Json;
    using System;

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }

    }
}