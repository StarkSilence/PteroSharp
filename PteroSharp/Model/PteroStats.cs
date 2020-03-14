using Newtonsoft.Json;

namespace PteroSharp.Model
{
    [PteroResponse]
    public class PteroStats
    {
        [JsonProperty("state")]
        public string State { get; set; }
        
        [JsonProperty("memory")]
        public PteroMemory Memory { get; set; }
        
        [JsonProperty("cpu")]
        public PteroCPU CPU { get; set; }
        
        [JsonProperty("disk")]
        public PteroDisk Disk { get; set; }
    }
}