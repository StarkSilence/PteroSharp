﻿using Newtonsoft.Json;

namespace PteroSharp.Model
{
    public class PteroServerLimits
    {
        [JsonProperty("memory")]
        public int Memory { get; set; }
        
        [JsonProperty("swap")]
        public int Swap { get; set; }
        
        [JsonProperty("disk")]
        public int Disk { get; set; }
        
        [JsonProperty("io")]
        public int IO { get; set; }
        
        [JsonProperty("cpu")]
        public int CPU { get; set; }
    }
}