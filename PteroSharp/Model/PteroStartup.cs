using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroStartup
    {
        [JsonProperty("done")]
        public string Done { get; set; }
        
        [JsonProperty("userInteraction")]
        public string[] UserInteraction { get; set; }
    }
}