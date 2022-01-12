namespace SwissTransport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; }
    }
}