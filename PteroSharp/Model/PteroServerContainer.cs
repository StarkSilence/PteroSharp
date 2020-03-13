using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroServerContainer
    {
        [JsonProperty("startup_command")]
        public string StartupCommand { get; set; }
        
        [JsonProperty("image")]
        public string Image { get; set; }
        
        [JsonProperty("installed")]
        public bool Installed { get; set; }
        
        [JsonProperty("environment")]
        public PteroServerContainerEnvironment Environment { get; set; }
    }
}