using Newtonsoft.Json;

namespace PteroSharp.Response
{
    public class PteroServerDeploy
    {
        [JsonProperty("locations")]
        public int[] Locations { get; set; }
        
        [JsonProperty("dedicated_ip")]
        public bool DedicatedIP { get; set; }
        
        [JsonProperty("port_range")]
        public string PortRange { get; set; }
    }
}