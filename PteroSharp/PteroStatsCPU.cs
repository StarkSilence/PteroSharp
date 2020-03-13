using Newtonsoft.Json;

namespace PteroSharp
{
    public class PteroStatsCPU
    {
        [JsonProperty("current")]
        public double Current { get; set; }
        
        [JsonProperty("cores")]
        public double[] Cores { get; set; }
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}