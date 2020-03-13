using Newtonsoft.Json;

namespace PteroSharp.Model.Response
{
    internal class PteroResponse
    {
        [JsonProperty("object")]
        public string ObjectType { get; set; }
        
        [JsonProperty("data")]
        public PteroResponseUser[] PteroResponseUsers { get; set; }
        
        [JsonProperty("meta")]
        public PteroResponseMeta Meta { get; set; }
    }
}