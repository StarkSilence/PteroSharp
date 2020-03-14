using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroFind
    {
        [JsonProperty("server-ip")]
        public string ServerIP { get; set; }
        
        [JsonProperty("enable-query")]
        public string EnableQuery { get; set; }
        
        [JsonProperty("server-port")]
        public string ServerPort { get; set; }
        
        [JsonProperty("query.port")]
        public string QueryPort { get; set; }
    }
}