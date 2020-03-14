using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroDisk
    {
        [JsonProperty("current")]
        public int Current { get; set; }
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}