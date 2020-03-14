using Newtonsoft.Json;

namespace PteroSharp.Model
{
    [PteroResponse]
    public class PteroStats
    {
        [JsonProperty("state")]
        public string State { get; set; }
        
        [JsonProperty("memory")]
        public PteroStatsMemory Memory { get; set; }
        
        [JsonProperty("cpu")]
        public PteroStatsCPU CPU { get; set; }
        
        [JsonProperty("disk")]
        public PteroStatsDisk Disk { get; set; }
    }
}