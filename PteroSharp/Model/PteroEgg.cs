using System;
using Newtonsoft.Json;
using PteroSharp.Model.Sub;

namespace PteroSharp.Model
{
    [PteroResponse]
    public class PteroEgg
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("uuid")]
        public string UUID { get; set; }
        
        [JsonProperty("nest")]
        public int Nest { get; set; }
        
        [JsonProperty("author")]
        public string Author { get; set; }
        
        [JsonProperty("startup")]
        public string Startup { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("docker_image")]
        public string DockerImage { get; set; }
        
        [JsonProperty("config")]
        public PteroConfig Config { get; set; }
        
        [JsonProperty("script")]
        public PteroScript Script { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}