using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroStatsDisk
    {
        [JsonProperty("current")]
        public int Current { get; set; }
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}