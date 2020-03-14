using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroScript
    {
        [JsonProperty("privileged")]
        public bool Privileged { get; set; }
        
        [JsonProperty("install")]
        public string Install { get; set; }
        
        [JsonProperty("entry")]
        public string Entry { get; set; }
        
        [JsonProperty("container")]
        public string Container { get; set; }
        
        [JsonProperty("extends")]
        public object Extends { get; set; }
    }
}