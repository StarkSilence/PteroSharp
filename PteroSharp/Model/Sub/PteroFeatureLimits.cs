using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroFeatureLimits
    {
        [JsonProperty("databases")]
        public int Databases { get; set; }
        
        [JsonProperty("allocations")]
        public int Allocations { get; set; }
    }
}