using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroEnvironment
    {
        [JsonProperty("SERVER_JARFILE")]
        public string ServerJarFile { get; set; }
        
        [JsonProperty("VANILLA_VERSION")]
        public string VanillaVersion { get; set; }
        
        [JsonProperty("STARTUP")]
        public string Startup { get; set; }
        
        [JsonProperty("P_SERVER_LOCATION")]
        public string ServerLocation { get; set; }
        
        [JsonProperty("P_SERVER_UUID")]
        public string ServerUUID { get; set; }
    }
}