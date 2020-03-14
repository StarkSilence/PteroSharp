using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroContainer
    {
        [JsonProperty("startup_command")]
        public string StartupCommand { get; set; }
        
        [JsonProperty("image")]
        public string Image { get; set; }
        
        [JsonProperty("installed")]
        public bool Installed { get; set; }
        
        [JsonProperty("environment")]
        public PteroEnvironment Environment { get; set; }
    }
}