using Newtonsoft.Json;

namespace PteroSharp
{
    public class PteroStatsMemory
    {
        
        [JsonProperty("current")]
        public int Current { get; set; }
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}