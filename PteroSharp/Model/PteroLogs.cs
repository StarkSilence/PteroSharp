using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroLogs
    {
        [JsonProperty("custom")]
        public bool Custom { get; set; }
        
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}