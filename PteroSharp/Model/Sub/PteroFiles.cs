using Newtonsoft.Json;

namespace PteroSharp.Model.Sub
{
    public class PteroFiles
    {
        [JsonProperty("server.properties")]
        public PteroServerProperties ServerProperties { get; set; }
    }
}