using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroConfig
    {
        [JsonProperty("files")]
        public PteroFiles Files { get; set; }
        
        [JsonProperty("startup")]
        public PteroStartup Startup { get; set; }
        
        [JsonProperty("stop")]
        public string Stop { get; set; }
        
        [JsonProperty("logs")]
        public PteroLogs Logs { get; set; }
        
        [JsonProperty("extends")]
        public object Extends { get; set; }
    }
}