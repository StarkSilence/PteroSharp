using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroFiles
    {
        [JsonProperty("server.properties")]
        public PteroServerProperties ServerProperties { get; set; }
    }
}