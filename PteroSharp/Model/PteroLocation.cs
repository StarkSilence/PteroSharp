using System;
using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroLocation
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("short")]
        public string Short { get; set; }
        
        [JsonProperty("long")]
        public string Long { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}