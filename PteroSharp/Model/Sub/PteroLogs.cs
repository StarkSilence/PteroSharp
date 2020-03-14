using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroLogs
    {
        [JsonProperty("custom")]
        public bool Custom { get; set; }
        
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}