﻿using System;
using Newtonsoft.Json;
using PteroSharp.Model.Sub;

namespace PteroSharp.Model
{
    [PteroResponse]
    public class PteroServer
    {
        [JsonProperty("id")]
        public int? ID { get; set; }
        
        [JsonProperty("external_id")]
        public string ExternalID { get; set; }
        
        [JsonProperty("uuid")]
        public string UUID { get; set; }
        
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        
        [JsonProperty("server_owner")]
        public bool ServerOwner { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
        
        [JsonProperty("limits")]
        public PteroLimits Limits { get; set; }
        
        [JsonProperty("feature_limits")]
        public PteroFeatureLimits FeatureLimits { get; set; }
        
        [JsonProperty("user")]
        public int User { get; set; }
        
        [JsonProperty("node")]
        public int Node { get; set; }
        
        [JsonProperty("allocation")]
        public int Allocation { get; set; }
        
        [JsonProperty("nest")]
        public int Nest { get; set; }
        
        [JsonProperty("egg")]
        public int Egg { get; set; }
        
        [JsonProperty("pack")]
        public int? Pack { get; set; }
        
        [JsonProperty("docker_image")]
        public string DockerImage { get; set; }
        
        [JsonProperty("startup")]
        public string Startup { get; set; }
        
        [JsonProperty("deploy")]
        public PteroDeploy Deploy { get; set; }
        
        [JsonProperty("container")]
        public PteroContainer Container { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}