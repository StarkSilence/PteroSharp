using System;
using Newtonsoft.Json;

namespace PteroSharp
{
    public class PteroNest
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("uuid")]
        public string UUID { get; set; }
        
        [JsonProperty("author")]
        public string Author { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}