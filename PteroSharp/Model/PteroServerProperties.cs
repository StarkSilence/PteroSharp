using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroServerProperties
    {
        [JsonProperty("parser")]
        public string Parser { get; set; }
        
        [JsonProperty("find")]
        public PteroFind Find { get; set; }
    }
}